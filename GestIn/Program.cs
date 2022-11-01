using GestIn.UI.Home;
using GestIn.UI.Home.ExamEnrolment;
using GestIn.UI.Home.Grades;
using GestIn.UI.Home.Students;
using GestIn.UI.Login;
namespace GestIn
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new test());
            Application.Run(new formHome());
        }
    }
}