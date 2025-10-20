namespace InventorySystem
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form currentForm = new LoginForm();

            while (currentForm != null)
            {
                Application.Run(currentForm);

                if (currentForm.Tag is string next)
                {
                    switch (next)
                    {
                        case "AdminLoginForm":
                            currentForm = new AdminLoginForm();
                            break;
                        case "StaffLoginForm":
                            currentForm = new StaffLoginForm();
                            break;
                        case "AdminHomeForm":
                            currentForm = new AdminHomeForm();
                            break;
                        case "StaffHomeForm":
                            currentForm = new StaffHomeForm();
                            break;
                        case "Back":
                            currentForm = new LoginForm();
                            break;
                        default:
                            currentForm = new LoginForm();
                            break;
                    }
                }
                else
                {
                    currentForm = null;
                }
            }
        }
    }
}
 