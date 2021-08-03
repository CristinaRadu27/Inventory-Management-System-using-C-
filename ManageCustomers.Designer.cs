
namespace InventoryManagement
{
    partial class ManageCustomers
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerIDBox = new System.Windows.Forms.TextBox();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.customerPhoneBox = new System.Windows.Forms.TextBox();
            this.customerGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 125);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(390, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manage Customers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(148, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(910, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerIDBox
            // 
            this.customerIDBox.BackColor = System.Drawing.Color.LightGreen;
            this.customerIDBox.Location = new System.Drawing.Point(39, 172);
            this.customerIDBox.Name = "customerIDBox";
            this.customerIDBox.Size = new System.Drawing.Size(248, 27);
            this.customerIDBox.TabIndex = 1;
            this.customerIDBox.Text = "CustomerID";
            this.customerIDBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // customerNameBox
            // 
            this.customerNameBox.BackColor = System.Drawing.Color.LightGreen;
            this.customerNameBox.Location = new System.Drawing.Point(39, 225);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(248, 27);
            this.customerNameBox.TabIndex = 2;
            this.customerNameBox.Text = "CustomerName";
            this.customerNameBox.TextChanged += new System.EventHandler(this.customerNameBox_TextChanged);
            // 
            // customerPhoneBox
            // 
            this.customerPhoneBox.BackColor = System.Drawing.Color.LightGreen;
            this.customerPhoneBox.Location = new System.Drawing.Point(39, 282);
            this.customerPhoneBox.Name = "customerPhoneBox";
            this.customerPhoneBox.Size = new System.Drawing.Size(248, 27);
            this.customerPhoneBox.TabIndex = 3;
            this.customerPhoneBox.Text = "CustomerPhone";
            // 
            // customerGV
            // 
            this.customerGV.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.customerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGV.Location = new System.Drawing.Point(355, 214);
            this.customerGV.Name = "customerGV";
            this.customerGV.RowHeadersWidth = 51;
            this.customerGV.RowTemplate.Height = 29;
            this.customerGV.Size = new System.Drawing.Size(800, 430);
            this.customerGV.TabIndex = 4;
            this.customerGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(591, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 59);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(39, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(179, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(111, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(73, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 57);
            this.button4.TabIndex = 9;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 772);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1201, 20);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 669);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 96);
            this.panel3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(89, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 47);
            this.label5.TabIndex = 3;
            this.label5.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Orders Count";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(427, 671);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 96);
            this.panel4.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(96, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 47);
            this.label6.TabIndex = 3;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SeaGreen;
            this.label7.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 47);
            this.label7.TabIndex = 3;
            this.label7.Text = "Orders Amount";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaGreen;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(837, 669);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 96);
            this.panel5.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(136, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 47);
            this.label8.TabIndex = 3;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SeaGreen;
            this.label9.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(30, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 47);
            this.label9.TabIndex = 3;
            this.label9.Text = "Last Order Date";
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 791);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerGV);
            this.Controls.Add(this.customerPhoneBox);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.customerIDBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ManageCustomers";
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerIDBox;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox customerPhoneBox;
        private System.Windows.Forms.DataGridView customerGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}