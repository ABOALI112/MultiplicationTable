
namespace MultiplicationTable
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListField = new System.Windows.Forms.ListBox();
            this.inputfield = new System.Windows.Forms.TextBox();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.Reset_Button1 = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplication Table";
            // 
            // ListField
            // 
            this.ListField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListField.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListField.FormattingEnabled = true;
            this.ListField.ItemHeight = 28;
            this.ListField.Location = new System.Drawing.Point(7, 70);
            this.ListField.Name = "ListField";
            this.ListField.Size = new System.Drawing.Size(258, 312);
            this.ListField.TabIndex = 1;
            this.ListField.SelectedIndexChanged += new System.EventHandler(this.ListField_SelectedIndexChanged);
            // 
            // inputfield
            // 
            this.inputfield.Location = new System.Drawing.Point(354, 70);
            this.inputfield.Multiline = true;
            this.inputfield.Name = "inputfield";
            this.inputfield.Size = new System.Drawing.Size(234, 51);
            this.inputfield.TabIndex = 2;
            this.inputfield.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Multiply_Button.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply_Button.Location = new System.Drawing.Point(379, 156);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(156, 56);
            this.Multiply_Button.TabIndex = 3;
            this.Multiply_Button.Text = "Multiply";
            this.Multiply_Button.UseVisualStyleBackColor = false;
            this.Multiply_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reset_Button1
            // 
            this.Reset_Button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Button1.Location = new System.Drawing.Point(379, 232);
            this.Reset_Button1.Name = "Reset_Button1";
            this.Reset_Button1.Size = new System.Drawing.Size(156, 56);
            this.Reset_Button1.TabIndex = 3;
            this.Reset_Button1.Text = "Reset";
            this.Reset_Button1.UseVisualStyleBackColor = true;
            this.Reset_Button1.Click += new System.EventHandler(this.Reset_Button);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Location = new System.Drawing.Point(379, 294);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(156, 56);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(637, 410);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Reset_Button1);
            this.Controls.Add(this.Multiply_Button);
            this.Controls.Add(this.inputfield);
            this.Controls.Add(this.ListField);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MuiltiplicationTable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListField;
        private System.Windows.Forms.TextBox inputfield;
        private System.Windows.Forms.Button Multiply_Button;
        private System.Windows.Forms.Button Reset_Button1;
        private System.Windows.Forms.Button Exit_Button;
    }
}

