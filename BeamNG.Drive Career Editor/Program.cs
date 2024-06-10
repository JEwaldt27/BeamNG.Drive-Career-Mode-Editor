using System;
using System.Windows.Forms;

namespace BeamNG.Drive_Career_Editor
{
    static class Program
    {
        public static string FilePath { get; set; } = string.Empty;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}
