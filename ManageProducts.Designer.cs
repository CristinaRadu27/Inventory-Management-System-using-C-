
namespace InventoryManagement
{
    partial class ManageProducts
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
            this.productPriceBox = new System.Windows.Forms.TextBox();
            this.productQuantityBox = new System.Windows.Forms.TextBox();
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.productIDBox = new System.Windows.Forms.TextBox();
            this.productDescriptionBox = new System.Windows.Forms.TextBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 125);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(390, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manage Products";
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
            // 
            // productPriceBox
            // 
            this.productPriceBox.BackColor = System.Drawing.Color.LightGreen;
            this.productPriceBox.Location = new System.Drawing.Point(37, 353);
            this.productPriceBox.Name = "productPriceBox";
            this.productPriceBox.Size = new System.Drawing.Size(247, 27);
            this.productPriceBox.TabIndex = 12;
            this.productPriceBox.Text = " Product Price";
            this.productPriceBox.TextChanged += new System.EventHandler(this.telephoneBox_TextChanged);
            // 
            // productQuantityBox
            // 
            this.productQuantityBox.BackColor = System.Drawing.Color.LightGreen;
            this.productQuantityBox.Location = new System.Drawing.Point(37, 293);
            this.productQuantityBox.Name = "productQuantityBox";
            this.productQuantityBox.Size = new System.Drawing.Size(247, 27);
            this.productQuantityBox.TabIndex = 11;
            this.productQuantityBox.Text = " Product Quantity";
            this.productQuantityBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // productNameBox
            // 
            this.productNameBox.BackColor = System.Drawing.Color.LightGreen;
            this.productNameBox.Location = new System.Drawing.Point(37, 228);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(247, 27);
            this.productNameBox.TabIndex = 10;
            this.productNameBox.Text = " Product Name";
            this.productNameBox.TextChanged += new System.EventHandler(this.fullnameBox_TextChanged);
            // 
            // productIDBox
            // 
            this.productIDBox.BackColor = System.Drawing.Color.LightGreen;
            this.productIDBox.Location = new System.Drawing.Point(37, 171);
            this.productIDBox.Name = "productIDBox";
            this.productIDBox.Size = new System.Drawing.Size(247, 27);
            this.productIDBox.TabIndex = 9;
            this.productIDBox.Text = " Product ID";
            this.productIDBox.TextChanged += new System.EventHandler(this.userNameBox_TextChanged);
            // 
            // productDescriptionBox
            // 
            this.productDescriptionBox.BackColor = System.Drawing.Color.LightGreen;
            this.productDescriptionBox.Location = new System.Drawing.Point(37, 412);
            this.productDescriptionBox.Name = "productDescriptionBox";
            this.productDescriptionBox.Size = new System.Drawing.Size(247, 27);
            this.productDescriptionBox.TabIndex = 17;
            this.productDescriptionBox.Text = "Description";
            // 
            // categoryCombo
            // 
            this.categoryCombo.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryCombo.ForeColor = System.Drawing.Color.SeaGreen;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(37, 463);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(247, 27);
            this.categoryCombo.TabIndex = 18;
            this.categoryCombo.Text = "Product category";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(67, 649);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 57);
            this.button4.TabIndex = 22;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(103, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 53);
            this.button3.TabIndex = 21;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(176, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 53);
            this.button2.TabIndex = 20;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(37, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // productGV
            // 
            this.productGV.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.productGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGV.Location = new System.Drawing.Point(317, 228);
            this.productGV.Name = "productGV";
            this.productGV.RowHeadersWidth = 51;
            this.productGV.RowTemplate.Height = 29;
            this.productGV.Size = new System.Drawing.Size(815, 524);
            this.productGV.TabIndex = 23;
            this.productGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(567, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 59);
            this.label4.TabIndex = 24;
            this.label4.Text = "Products List";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 798);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.productDescriptionBox);
            this.Controls.Add(this.productPriceBox);
            this.Controls.Add(this.productQuantityBox);
            this.Controls.Add(this.productNameBox);
            this.Controls.Add(this.productIDBox);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProducts";
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productPriceBox;
        private System.Windows.Forms.TextBox productQuantityBox;
        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.TextBox productIDBox;
        private System.Windows.Forms.TextBox productDescriptionBox;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView productGV;
        private System.Windows.Forms.Label label4;
    }
}