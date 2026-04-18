
namespace BakeryManagement
{
    partial class LogIn1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn1));
            this.BakerLoginbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerLogInButton = new System.Windows.Forms.Button();
            this.ManagerLoginbutton = new System.Windows.Forms.Button();
            this.AdminLogInbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BakerLoginbutton
            // 
            this.BakerLoginbutton.BackColor = System.Drawing.Color.SeaShell;
            this.BakerLoginbutton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakerLoginbutton.Location = new System.Drawing.Point(137, 261);
            this.BakerLoginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BakerLoginbutton.Name = "BakerLoginbutton";
            this.BakerLoginbutton.Size = new System.Drawing.Size(247, 42);
            this.BakerLoginbutton.TabIndex = 14;
            this.BakerLoginbutton.Text = "BAKER";
            this.BakerLoginbutton.UseVisualStyleBackColor = false;
            this.BakerLoginbutton.Click += new System.EventHandler(this.BakerLoginbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Your Role To Log In -";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomerLogInButton
            // 
            this.CustomerLogInButton.BackColor = System.Drawing.Color.SeaShell;
            this.CustomerLogInButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLogInButton.Location = new System.Drawing.Point(140, 172);
            this.CustomerLogInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerLogInButton.Name = "CustomerLogInButton";
            this.CustomerLogInButton.Size = new System.Drawing.Size(247, 42);
            this.CustomerLogInButton.TabIndex = 10;
            this.CustomerLogInButton.Text = "CUSTOMER ";
            this.CustomerLogInButton.UseVisualStyleBackColor = false;
            this.CustomerLogInButton.Click += new System.EventHandler(this.CustomerLogInButton_Click);
            // 
            // ManagerLoginbutton
            // 
            this.ManagerLoginbutton.BackColor = System.Drawing.Color.SeaShell;
            this.ManagerLoginbutton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLoginbutton.Location = new System.Drawing.Point(137, 219);
            this.ManagerLoginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManagerLoginbutton.Name = "ManagerLoginbutton";
            this.ManagerLoginbutton.Size = new System.Drawing.Size(248, 37);
            this.ManagerLoginbutton.TabIndex = 12;
            this.ManagerLoginbutton.Text = "MANAGER ";
            this.ManagerLoginbutton.UseVisualStyleBackColor = false;
            this.ManagerLoginbutton.Click += new System.EventHandler(this.ManagerLoginbutton_Click);
            // 
            // AdminLogInbutton
            // 
            this.AdminLogInbutton.BackColor = System.Drawing.Color.SeaShell;
            this.AdminLogInbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminLogInbutton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogInbutton.Location = new System.Drawing.Point(137, 308);
            this.AdminLogInbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminLogInbutton.Name = "AdminLogInbutton";
            this.AdminLogInbutton.Size = new System.Drawing.Size(248, 39);
            this.AdminLogInbutton.TabIndex = 13;
            this.AdminLogInbutton.Text = "ADMIN";
            this.AdminLogInbutton.UseVisualStyleBackColor = false;
            this.AdminLogInbutton.Click += new System.EventHandler(this.AdminLogInbutton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BakeryManagement.Properties.Resources.back_button;
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LogIn1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(869, 436);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BakerLoginbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerLogInButton);
            this.Controls.Add(this.ManagerLoginbutton);
            this.Controls.Add(this.AdminLogInbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BakerLoginbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CustomerLogInButton;
        private System.Windows.Forms.Button ManagerLoginbutton;
        private System.Windows.Forms.Button AdminLogInbutton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}