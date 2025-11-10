namespace InventorySystem.Helper_Classes
{
    internal class PlaceholderHelper
    {
        public static void ApplyPlaceholder(RichTextBox textBox, string text)
        {
            textBox.ForeColor = Color.FromArgb(135, 135, 135);
            textBox.Text = text;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.ForeColor = Color.FromArgb(135, 135, 135);
                    textBox.Text = text;
                }
            };
        }
    }
}
