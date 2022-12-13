namespace ToDoList
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.TextBox();
            this.View_btn = new System.Windows.Forms.Button();
            this.NewItem_txtbx = new System.Windows.Forms.TextBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display.Location = new System.Drawing.Point(1, -3);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(600, 479);
            this.Display.TabIndex = 0;
            // 
            // View_btn
            // 
            this.View_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.View_btn.Location = new System.Drawing.Point(401, 478);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(199, 65);
            this.View_btn.TabIndex = 1;
            this.View_btn.Text = "View";
            this.View_btn.UseVisualStyleBackColor = true;
            this.View_btn.Click += new System.EventHandler(this.View_btn_Click);
            // 
            // NewItem_txtbx
            // 
            this.NewItem_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewItem_txtbx.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewItem_txtbx.Location = new System.Drawing.Point(7, 600);
            this.NewItem_txtbx.Multiline = true;
            this.NewItem_txtbx.Name = "NewItem_txtbx";
            this.NewItem_txtbx.PlaceholderText = "\"C:\\Users\\hp\\source\\repos\\ToDoList\\ToDoList.sln\"";
            this.NewItem_txtbx.Size = new System.Drawing.Size(593, 52);
            this.NewItem_txtbx.TabIndex = 2;
            this.NewItem_txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_btn.Location = new System.Drawing.Point(-3, 482);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(199, 58);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Add_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_btn.Location = new System.Drawing.Point(398, 659);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(203, 51);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "Add ";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 713);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.NewItem_txtbx);
            this.Controls.Add(this.View_btn);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Display;
        private Button View_btn;
        private TextBox NewItem_txtbx;
        private Button Delete_btn;
        private Button Add_btn;
    }
}