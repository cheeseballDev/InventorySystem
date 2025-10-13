namespace InventorySystem
{
    partial class StaffInventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbSearchProduct = new RichTextBox();
            SuspendLayout();
            // 
            // tbSearchProduct
            // 
            tbSearchProduct.Location = new Point(12, 12);
            tbSearchProduct.MaxLength = 20;
            tbSearchProduct.Multiline = false;
            tbSearchProduct.Name = "tbSearchProduct";
            tbSearchProduct.Size = new Size(142, 28);
            tbSearchProduct.TabIndex = 0;
            tbSearchProduct.Text = "";
            tbSearchProduct.TextChanged += tbSearchProduct_TextChanged;
            // 
            // StaffInventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(tbSearchProduct);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "StaffInventoryForm";
            Text = "StaffInventoryForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox tbSearchProduct;
    }
}