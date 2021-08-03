
namespace InventoryManagement
{
    partial class ManageCategories
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameBox = new System.Windows.Forms.TextBox();
            this.categoryIDBox = new System.Windows.Forms.TextBox();
            this.categoryGV = new System.Windows.Forms.DataGridView();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 127);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(324, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(910, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // categoryNameBox
            // 
            this.categoryNameBox.BackColor = System.Drawing.Color.LightGreen;
            this.categoryNameBox.Location = new System.Drawing.Point(29, 240);
            this.categoryNameBox.Name = "categoryNameBox";
            this.categoryNameBox.Size = new System.Drawing.Size(249, 27);
            this.categoryNameBox.TabIndex = 1;
            this.categoryNameBox.Text = "Category Name";
            // 
            // categoryIDBox
            // 
            this.categoryIDBox.BackColor = System.Drawing.Color.LightGreen;
            this.categoryIDBox.ForeColor = System.Drawing.Color.Black;
            this.categoryIDBox.Location = new System.Drawing.Point(29, 180);
            this.categoryIDBox.Name = "categoryIDBox";
            this.categoryIDBox.Size = new System.Drawing.Size(249, 27);
            this.categoryIDBox.TabIndex = 2;
            this.categoryIDBox.Text = "Category ID";
            // 
            // categoryGV
            // 
            this.categoryGV.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.categoryGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGV.Location = new System.Drawing.Point(326, 216);
            this.categoryGV.Name = "categoryGV";
            this.categoryGV.RowHeadersWidth = 51;
            this.categoryGV.RowTemplate.Height = 29;
            this.categoryGV.Size = new System.Drawing.Size(756, 481);
            this.categoryGV.TabIndex = 3;
            this.categoryGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.SeaGreen;
            this.addCategoryButton.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCategoryButton.Location = new System.Drawing.Point(29, 292);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(110, 52);
            this.addCategoryButton.TabIndex = 7;
            this.addCategoryButton.Text = "Add";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.BackColor = System.Drawing.Color.SeaGreen;
            this.editCategoryButton.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editCategoryButton.Location = new System.Drawing.Point(170, 291);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(108, 53);
            this.editCategoryButton.TabIndex = 8;
            this.editCategoryButton.Text = "Edit";
            this.editCategoryButton.UseVisualStyleBackColor = false;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.BackColor = System.Drawing.Color.SeaGreen;
            this.deleteCategoryButton.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCategoryButton.Location = new System.Drawing.Point(101, 365);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(105, 53);
            this.deleteCategoryButton.TabIndex = 9;
            this.deleteCategoryButton.Text = "Delete";
            this.deleteCategoryButton.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(64, 438);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 57);
            this.button4.TabIndex = 10;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(571, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 59);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category List";
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 709);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.editCategoryButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoryGV);
            this.Controls.Add(this.categoryIDBox);
            this.Controls.Add(this.categoryNameBox);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCategories";
            this.Text = "ManageCategories";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryNameBox;
        private System.Windows.Forms.TextBox categoryIDBox;
        private System.Windows.Forms.DataGridView categoryGV;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button editCategoryButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}