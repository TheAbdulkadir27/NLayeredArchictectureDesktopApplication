﻿namespace WebAray
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
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateStockPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateStockPerUnit = new System.Windows.Forms.Label();
            this.lblUpdateStockAmount = new System.Windows.Forms.Label();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.lblUpdatePrice = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStockPerUnit = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxProductPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxSearch.SuspendLayout();
            this.gbxCategory.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxProductName);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(19, 76);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(420, 62);
            this.gbxSearch.TabIndex = 14;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün İsmine Göre Ara :";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(93, 34);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(223, 20);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 41);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(29, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Ara :";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblKategori);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(19, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(420, 58);
            this.gbxCategory.TabIndex = 13;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Listele";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(18, 34);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(69, 13);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori ID : ";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(93, 34);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(223, 21);
            this.cbxCategory.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.cbxUpdateCategory);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.tbxUpdateStockPerUnit);
            this.groupBox3.Controls.Add(this.tbxUpdateStockAmount);
            this.groupBox3.Controls.Add(this.tbxUpdatePrice);
            this.groupBox3.Controls.Add(this.tbxUpdateName);
            this.groupBox3.Controls.Add(this.lblUpdateStockPerUnit);
            this.groupBox3.Controls.Add(this.lblUpdateStockAmount);
            this.groupBox3.Controls.Add(this.lblUpdateCategory);
            this.groupBox3.Controls.Add(this.lblUpdatePrice);
            this.groupBox3.Controls.Add(this.lblUpdateName);
            this.groupBox3.Location = new System.Drawing.Point(477, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 198);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Güncelle";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(102, 76);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(197, 21);
            this.cbxUpdateCategory.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateStockPerUnit
            // 
            this.tbxUpdateStockPerUnit.Location = new System.Drawing.Point(102, 131);
            this.tbxUpdateStockPerUnit.Name = "tbxUpdateStockPerUnit";
            this.tbxUpdateStockPerUnit.Size = new System.Drawing.Size(197, 20);
            this.tbxUpdateStockPerUnit.TabIndex = 8;
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(102, 105);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(197, 20);
            this.tbxUpdateStockAmount.TabIndex = 8;
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(102, 47);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(197, 20);
            this.tbxUpdatePrice.TabIndex = 6;
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(102, 15);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(197, 20);
            this.tbxUpdateName.TabIndex = 5;
            // 
            // lblUpdateStockPerUnit
            // 
            this.lblUpdateStockPerUnit.AutoSize = true;
            this.lblUpdateStockPerUnit.Location = new System.Drawing.Point(5, 133);
            this.lblUpdateStockPerUnit.Name = "lblUpdateStockPerUnit";
            this.lblUpdateStockPerUnit.Size = new System.Drawing.Size(65, 13);
            this.lblUpdateStockPerUnit.TabIndex = 4;
            this.lblUpdateStockPerUnit.Text = "Birim Adedi :";
            // 
            // lblUpdateStockAmount
            // 
            this.lblUpdateStockAmount.AutoSize = true;
            this.lblUpdateStockAmount.Location = new System.Drawing.Point(5, 107);
            this.lblUpdateStockAmount.Name = "lblUpdateStockAmount";
            this.lblUpdateStockAmount.Size = new System.Drawing.Size(65, 13);
            this.lblUpdateStockAmount.TabIndex = 3;
            this.lblUpdateStockAmount.Text = "Stok Adedi :";
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Location = new System.Drawing.Point(5, 76);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(85, 13);
            this.lblUpdateCategory.TabIndex = 2;
            this.lblUpdateCategory.Text = "Ürün Kategorisi :";
            // 
            // lblUpdatePrice
            // 
            this.lblUpdatePrice.AutoSize = true;
            this.lblUpdatePrice.Location = new System.Drawing.Point(5, 49);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(63, 13);
            this.lblUpdatePrice.TabIndex = 1;
            this.lblUpdatePrice.Text = "Ürün Fiyatı :";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(5, 24);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(51, 13);
            this.lblUpdateName.TabIndex = 0;
            this.lblUpdateName.Text = "ÜrünAdı :";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxStockPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStockAmount);
            this.gbxProductAdd.Controls.Add(this.tbxProductPrice);
            this.gbxProductAdd.Controls.Add(this.tbxProductName2);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStockAmount);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblProductPrice);
            this.gbxProductAdd.Controls.Add(this.lblProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(19, 339);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(336, 198);
            this.gbxProductAdd.TabIndex = 14;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(102, 76);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(197, 21);
            this.cbxCategoryId.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(153, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStockPerUnit
            // 
            this.tbxStockPerUnit.Location = new System.Drawing.Point(102, 131);
            this.tbxStockPerUnit.Name = "tbxStockPerUnit";
            this.tbxStockPerUnit.Size = new System.Drawing.Size(197, 20);
            this.tbxStockPerUnit.TabIndex = 8;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(102, 105);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(197, 20);
            this.tbxStockAmount.TabIndex = 8;
            // 
            // tbxProductPrice
            // 
            this.tbxProductPrice.Location = new System.Drawing.Point(102, 47);
            this.tbxProductPrice.Name = "tbxProductPrice";
            this.tbxProductPrice.Size = new System.Drawing.Size(197, 20);
            this.tbxProductPrice.TabIndex = 6;
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(102, 15);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(197, 20);
            this.tbxProductName2.TabIndex = 5;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(5, 133);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(65, 13);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adedi :";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(5, 107);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(65, 13);
            this.lblStockAmount.TabIndex = 3;
            this.lblStockAmount.Text = "Stok Adedi :";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(5, 76);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(85, 13);
            this.lblCategoryId.TabIndex = 2;
            this.lblCategoryId.Text = "Ürün Kategorisi :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(5, 49);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(63, 13);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Ürün Fiyatı :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(5, 24);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(51, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "ÜrünAdı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 175);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 546);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateStockPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label lblUpdateStockPerUnit;
        private System.Windows.Forms.Label lblUpdateStockAmount;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.Label lblUpdatePrice;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxStockPerUnit;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxProductPrice;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

