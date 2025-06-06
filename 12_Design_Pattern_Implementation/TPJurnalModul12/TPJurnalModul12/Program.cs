using System;
using System.Windows.Forms;

namespace tpmodul12_2311104070
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Jalankan Form1 sebagai form utama
            Application.Run(new Form1());
        }
    }
}
