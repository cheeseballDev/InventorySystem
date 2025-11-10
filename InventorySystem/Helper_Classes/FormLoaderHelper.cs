namespace InventorySystem.Helper_Classes
{
    internal class FormLoaderHelper
    {
        public static void LoadForm(Panel panel, Form formToLoad, Label lblTitle, Label lblDescription, string title, string description)
        {
            lblTitle.Text = title;
            lblDescription.Text = description;

            panel.Controls.Clear();
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(formToLoad);
            formToLoad.Show();
        }
    }
}
