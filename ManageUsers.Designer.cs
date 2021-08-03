
namespace InventoryManagement
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.fullnameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.telephoneBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.userGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 132);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(163, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(910, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(440, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Users";
            // 
            // userNameBox
            // 
            this.userNameBox.BackColor = System.Drawing.Color.LightGreen;
            this.userNameBox.Location = new System.Drawing.Point(12, 164);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(247, 27);
            this.userNameBox.TabIndex = 1;
            this.userNameBox.Text = "UserName";
            this.userNameBox.TextChanged += new System.EventHandler(this.userNameBox_TextChanged);
            // 
            // fullnameBox
            // 
            this.fullnameBox.BackColor = System.Drawing.Color.LightGreen;
            this.fullnameBox.Location = new System.Drawing.Point(12, 221);
            this.fullnameBox.Name = "fullnameBox";
            this.fullnameBox.Size = new System.Drawing.Size(247, 27);
            this.fullnameBox.TabIndex = 2;
            this.fullnameBox.Text = "Full name";
            this.fullnameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.LightGreen;
            this.passwordBox.Location = new System.Drawing.Point(12, 286);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(247, 27);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.Text = "Password";
            // 
            // telephoneBox
            // 
            this.telephoneBox.BackColor = System.Drawing.Color.LightGreen;
            this.telephoneBox.Location = new System.Drawing.Point(12, 350);
            this.telephoneBox.Name = "telephoneBox";
            this.telephoneBox.Size = new System.Drawing.Size(247, 27);
            this.telephoneBox.TabIndex = 4;
            this.telephoneBox.Text = "Telephone";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(151, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(78, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(42, 531);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 57);
            this.button4.TabIndex = 8;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // userGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            this.userGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userGV.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.userGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.userGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGV.Location = new System.Drawing.Point(321, 221);
            this.userGV.Name = "userGV";
            this.userGV.RowHeadersWidth = 51;
            this.userGV.RowTemplate.Height = 29;
            this.userGV.Size = new System.Drawing.Size(832, 419);
            this.userGV.TabIndex = 9;
            this.userGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 688);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 18);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(636, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 59);
            this.label3.TabIndex = 11;
            this.label3.Text = "User List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 709);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telephoneBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.fullnameBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox fullnameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox telephoneBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView userGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}