using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareLogger
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HardwareLogger());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HardwareLogger());
            using (NotifyIcon icon = new NotifyIcon())
            {
                icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                icon.ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Show form", (s, e) => {new HardwareLogger().Show();}),
                new MenuItem("Exit", (s, e) => { Application.Exit(); }),
            });
                icon.Visible = true;
                Application.Run();
                icon.Visible = false;
                
            }
        }
    }
}
