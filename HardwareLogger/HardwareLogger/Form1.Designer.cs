namespace HardwareLogger
{
    partial class HardwareLogger
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareLogger));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.bgUpdateMonitoring = new System.ComponentModel.BackgroundWorker();
            this.cLBDevices = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cLBSensorTypes = new System.Windows.Forms.CheckedListBox();
            this.cLBSensorNames = new System.Windows.Forms.CheckedListBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bgUpdateMonitoring
            // 
            this.bgUpdateMonitoring.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgUpdateMonitoring_DoWork);
            // 
            // cLBDevices
            // 
            this.cLBDevices.FormattingEnabled = true;
            this.cLBDevices.Location = new System.Drawing.Point(36, 57);
            this.cLBDevices.Name = "cLBDevices";
            this.cLBDevices.Size = new System.Drawing.Size(190, 199);
            this.cLBDevices.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбранные параметры для записи лога";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Устройства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Типы сенсоров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Названия сенсоров";
            // 
            // cLBSensorTypes
            // 
            this.cLBSensorTypes.FormattingEnabled = true;
            this.cLBSensorTypes.Location = new System.Drawing.Point(232, 57);
            this.cLBSensorTypes.Name = "cLBSensorTypes";
            this.cLBSensorTypes.Size = new System.Drawing.Size(190, 199);
            this.cLBSensorTypes.TabIndex = 5;
            // 
            // cLBSensorNames
            // 
            this.cLBSensorNames.FormattingEnabled = true;
            this.cLBSensorNames.Location = new System.Drawing.Point(428, 57);
            this.cLBSensorNames.Name = "cLBSensorNames";
            this.cLBSensorNames.Size = new System.Drawing.Size(190, 199);
            this.cLBSensorNames.TabIndex = 6;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(246, 278);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(167, 23);
            this.btnSaveSettings.TabIndex = 7;
            this.btnSaveSettings.Text = "Сохранить настройки";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // HardwareLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 332);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.cLBSensorNames);
            this.Controls.Add(this.cLBSensorTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cLBDevices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HardwareLogger";
            this.Text = "HardwareLogger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.ComponentModel.BackgroundWorker bgUpdateMonitoring;
        private System.Windows.Forms.CheckedListBox cLBDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cLBSensorTypes;
        private System.Windows.Forms.CheckedListBox cLBSensorNames;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}

