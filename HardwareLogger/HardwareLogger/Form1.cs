using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenHardwareMonitor.Collections;
using OpenHardwareMonitor.Hardware;
using System.Threading;
using System.Globalization;

namespace HardwareLogger
{
    public partial class HardwareLogger : Form
    {
        string[] sensors = {"CPU Total", "CPU Package",  "Memory", "GPU Core", "GPU Video Engine", "GPU Memory", "Used Space"};

        protected readonly ListSet<ISensor> active = new ListSet<ISensor>();
        public event SensorEventHandler SensorAdded;
        //добавить пуск\паузу, настройку интервала, сохранение\загрузку настроек
        protected virtual void ActivateSensor(ISensor sensor)
        {
            if (active.Add(sensor))
                if (SensorAdded != null)
                    SensorAdded(sensor);
        }

        public HardwareLogger()
        {
            InitializeComponent();
            ReadNames();
            bgUpdateMonitoring.RunWorkerAsync();
        }

        void ReadNames()
        {
            var myComputer = new Computer();
            myComputer.CPUEnabled = true;
            myComputer.GPUEnabled = true;
            myComputer.RAMEnabled = true;
            myComputer.HDDEnabled = true;
            myComputer.MainboardEnabled = true;
            myComputer.Open();
            
            foreach (var hardwareItem in myComputer.Hardware)
            {
                hardwareItem.Update();
                cLBDevices.Items.Add(hardwareItem.Name);
                foreach (var sensor in hardwareItem.Sensors)
                {
                    if (!cLBSensorNames.Items.Contains(sensor.Name))
                    {
                        cLBSensorNames.Items.Add(sensor.Name);
                    }
                    if (!cLBSensorTypes.Items.Contains(sensor.SensorType))
                    {
                        cLBSensorTypes.Items.Add(sensor.SensorType);
                    }
                }
            }
        }

        void ReadWriteLog()
        {
            string FileName = "HLog.csv";
            StreamWriter csv = new StreamWriter(FileName, true, System.Text.Encoding.GetEncoding(1251)); // Win-кодировка

            var myComputer = new Computer();
            myComputer.CPUEnabled = true;
            myComputer.GPUEnabled = true;
            myComputer.RAMEnabled = true;
            myComputer.HDDEnabled = true;
            myComputer.MainboardEnabled = true;
            myComputer.Open();

            foreach (var hardwareItem in myComputer.Hardware)
            {
                hardwareItem.Update();
                if(cLBDevices.CheckedItems.Contains(hardwareItem.Name))
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if(cLBSensorNames.CheckedItems.Contains(sensor.Name) && cLBSensorTypes.CheckedItems.Contains(sensor.SensorType))//if(sensors.Contains(sensor.Name) && (sensor.SensorType == SensorType.Load || sensor.SensorType == SensorType.Temperature))
                        {
                            string time = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss:fff");
                            csv.WriteLine(time + ";" + hardwareItem.Name + ";" + sensor.SensorType + ";" + sensor.Name + ";" + String.Format(CultureInfo.InvariantCulture, "{0:0.00}", sensor.Value));
                        }
                    }
            }
            csv.Close();
        }

        private void bgUpdateMonitoring_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(1000);
                    ReadWriteLog();
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            
        }

        void SaveSettings()
        {
            string FileName = "Settings.csv";
            StreamWriter csv = new StreamWriter(FileName, false, System.Text.Encoding.GetEncoding(1251)); // Win-кодировка


            csv.Close();
        }

        void LoadSettings()
        {

        }
    }
}
