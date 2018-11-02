using System;
using minTools;
using minTools.Config;
using System.Windows.Forms;

namespace minTools
{
    

    static class Program
    {
        static class Constants
        {
            public static string file_config = "config.cfg";
        }

        static void init()
        {
        }

        static void loadConfig()
        {
            IniFile ini = new IniFile(Constants.file_config);

            if (!ini.isLoaded())
                return;

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
