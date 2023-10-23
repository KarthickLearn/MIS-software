namespace MIS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.Run(new Login());
           // To customize application configuration such as set high DPI settings or default font,
             //see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Excel excel = Excel.Getobj();

            string cell = excel.Readcell(1, 3);
            DirectoryInfo dcf = new DirectoryInfo(@cell + "\\MIS Folder");
            if (dcf.Exists)
            {

                Application.Run(new MIS_Report());
                //Application.Run(new Login());

            }

            else
            {
                MessageBox.Show("Plz select your worksspace to perfrome!!!!");
                Application.Run(new Path_cre());
            }



        }
    }
}