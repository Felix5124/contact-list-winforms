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
            HoTen = new System.Windows.Forms.TextBox();
            SDT = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            Email = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // HoTen
            // 
            HoTen.Location = new System.Drawing.Point(12, 39);
            HoTen.Name = "HoTen";
            HoTen.Size = new System.Drawing.Size(199, 27);
            HoTen.TabIndex = 0;
            // 
            // SDT
            // 
            SDT.Location = new System.Drawing.Point(12, 72);
            SDT.Name = "SDT";
            SDT.Size = new System.Drawing.Size(199, 27);
            SDT.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 138);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            Email.Location = new System.Drawing.Point(12, 105);
            Email.Name = "Email";
            Email.Size = new System.Drawing.Size(199, 27);
            Email.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 23);
            label1.TabIndex = 3;
            label1.Text = "Thông tin bổ sung";
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Email);
            Controls.Add(SDT);
            Controls.Add(HoTen);
            Text = "AddContactForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox Email;

        #endregion

        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Button button1;
    }
}