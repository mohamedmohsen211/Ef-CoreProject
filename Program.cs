

using WinFormsApp2.DAL.Database;
using WinFormsApp2.DAL.Entites;
using WinFormsApp2.Forms;

namespace WinFormsApp2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainLoginform());
            

        }
    }
}