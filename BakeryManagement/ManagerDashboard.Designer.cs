
namespace BakeryManagement
{
    partial class ManagerDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPM = new System.Windows.Forms.Button();
            this.buttonBI = new System.Windows.Forms.Button();
            this.buttonCM = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.show = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.PP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.buttonPM);
            this.panel1.Controls.Add(this.buttonBI);
            this.panel1.Controls.Add(this.buttonCM);
            this.panel1.Controls.Add(this.buttonlogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 660);
            this.panel1.TabIndex = 4;
            // 
            // buttonPM
            // 
            this.buttonPM.BackColor = System.Drawing.Color.Transparent;
            this.buttonPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPM.Location = new System.Drawing.Point(4, 240);
            this.buttonPM.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPM.Name = "buttonPM";
            this.buttonPM.Size = new System.Drawing.Size(307, 62);
            this.buttonPM.TabIndex = 8;
            this.buttonPM.Text = "product Manage";
            this.buttonPM.UseVisualStyleBackColor = false;
            // 
            // buttonBI
            // 
            this.buttonBI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBI.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBI.Location = new System.Drawing.Point(4, 475);
            this.buttonBI.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBI.Name = "buttonBI";
            this.buttonBI.Size = new System.Drawing.Size(307, 62);
            this.buttonBI.TabIndex = 7;
            this.buttonBI.Text = "Baker Informed";
            this.buttonBI.UseVisualStyleBackColor = true;
            this.buttonBI.Click += new System.EventHandler(this.buttonBI_Click);
            // 
            // buttonCM
            // 
            this.buttonCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCM.Location = new System.Drawing.Point(5, 362);
            this.buttonCM.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCM.Name = "buttonCM";
            this.buttonCM.Size = new System.Drawing.Size(305, 62);
            this.buttonCM.TabIndex = 6;
            this.buttonCM.Text = "Customer Manage";
            this.buttonCM.UseVisualStyleBackColor = true;
            this.buttonCM.Click += new System.EventHandler(this.buttonCM_Click);
            // 
            // buttonlogout
            // 
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.Location = new System.Drawing.Point(4, 598);
            this.buttonlogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(307, 62);
            this.buttonlogout.TabIndex = 5;
            this.buttonlogout.Text = "Logout";
            this.buttonlogout.UseVisualStyleBackColor = true;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakeryManagement.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(121, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BakeryManagement.Properties.Resources.Gemini_Generated_Image_d615jad615jad615;
            this.pictureBox2.Location = new System.Drawing.Point(319, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1061, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(727, 287);
            this.show.Margin = new System.Windows.Forms.Padding(4);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(175, 28);
            this.show.TabIndex = 39;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(727, 244);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(175, 28);
            this.delete.TabIndex = 38;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // PP
            // 
            this.PP.Location = new System.Drawing.Point(519, 283);
            this.PP.Margin = new System.Windows.Forms.Padding(4);
            this.PP.Name = "PP";
            this.PP.Size = new System.Drawing.Size(132, 22);
            this.PP.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Price :";
            // 
            // PQ
            // 
            this.PQ.Location = new System.Drawing.Point(519, 246);
            this.PQ.Margin = new System.Windows.Forms.Padding(4);
            this.PQ.Name = "PQ";
            this.PQ.Size = new System.Drawing.Size(132, 22);
            this.PQ.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Quantity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Prodect Name : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(727, 204);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(175, 28);
            this.add.TabIndex = 27;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 339);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(976, 298);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(519, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(931, 246);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(175, 69);
            this.update.TabIndex = 42;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 665);
            this.Controls.Add(this.update);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.PP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPM;
        private System.Windows.Forms.Button buttonBI;
        private System.Windows.Forms.Button buttonCM;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox PP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button update;
    }
}