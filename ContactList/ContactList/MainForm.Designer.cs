﻿namespace ContactList;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label1 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(128, 23);
        label1.TabIndex = 0;
        label1.Text = "Danh sách liên hệ";
        // 
        // button1
        // 
        button1.Location = new Point(12, 35);
        button1.Name = "button1";
        button1.Size = new Size(111, 28);
        button1.TabIndex = 1;
        button1.Text = "Thêm liên hệ";
        button1.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "MainForm";
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    #endregion
}