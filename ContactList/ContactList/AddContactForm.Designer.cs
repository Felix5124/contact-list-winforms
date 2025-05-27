namespace ContactList
{
    partial class AddContactForm
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
            HoTen = new TextBox();
            SDT = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // HoTen
            // 
            HoTen.Location = new Point(12, 12);
            HoTen.Name = "HoTen";
            HoTen.Size = new Size(125, 27);
            HoTen.TabIndex = 0;
            // 
            // SDT
            // 
            SDT.Location = new Point(12, 45);
            SDT.Name = "SDT";
            SDT.Size = new Size(125, 27);
            SDT.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 78);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(SDT);
            Controls.Add(HoTen);
            Name = "AddContactForm";
            Text = "AddContactForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox HoTen;
        private TextBox SDT;
        private Button button1;
    }
}