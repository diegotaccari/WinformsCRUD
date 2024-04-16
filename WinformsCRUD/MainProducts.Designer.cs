namespace WinformsCRUD
{
    partial class MainProducts
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
            this.components = new System.ComponentModel.Container();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.productocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearchProduct = new System.Windows.Forms.TextBox();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.txtIncremto = new System.Windows.Forms.TextBox();
            this.btnPrecioCosto = new System.Windows.Forms.Button();
            this.txtIncremtoPC = new System.Windows.Forms.TextBox();
            this.lblCantidadADescontar = new System.Windows.Forms.Label();
            this.txtBCantidadAdescontar = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(311, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.AllowDrop = true;
            this.btnBackMenu.Location = new System.Drawing.Point(422, 34);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(105, 29);
            this.btnBackMenu.TabIndex = 1;
            this.btnBackMenu.Text = "Back Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(556, 34);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(105, 29);
            this.BtnAddProduct.TabIndex = 2;
            this.BtnAddProduct.Text = "AddProduct";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // gridProducts
            // 
            this.gridProducts.AutoGenerateColumns = false;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.denominacionDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.precioCostoDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.gridProducts.DataSource = this.productocBindingSource;
            this.gridProducts.Location = new System.Drawing.Point(1, 107);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(738, 259);
            this.gridProducts.TabIndex = 3;
            this.gridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // denominacionDataGridViewTextBoxColumn
            // 
            this.denominacionDataGridViewTextBoxColumn.DataPropertyName = "Denominacion";
            this.denominacionDataGridViewTextBoxColumn.HeaderText = "Denominacion";
            this.denominacionDataGridViewTextBoxColumn.Name = "denominacionDataGridViewTextBoxColumn";
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            // 
            // precioCostoDataGridViewTextBoxColumn
            // 
            this.precioCostoDataGridViewTextBoxColumn.DataPropertyName = "PrecioCosto";
            this.precioCostoDataGridViewTextBoxColumn.HeaderText = "PrecioCosto";
            this.precioCostoDataGridViewTextBoxColumn.Name = "precioCostoDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Id";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // productocBindingSource
            // 
            this.productocBindingSource.DataSource = typeof(WinformsCRUD.Productoc);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Product";
            // 
            // txbSearchProduct
            // 
            this.txbSearchProduct.Location = new System.Drawing.Point(116, 39);
            this.txbSearchProduct.Name = "txbSearchProduct";
            this.txbSearchProduct.Size = new System.Drawing.Size(144, 20);
            this.txbSearchProduct.TabIndex = 5;
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Location = new System.Drawing.Point(311, 2);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(99, 26);
            this.btnPorcentaje.TabIndex = 6;
            this.btnPorcentaje.Text = "% Precio Venta";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // txtIncremto
            // 
            this.txtIncremto.Location = new System.Drawing.Point(416, 6);
            this.txtIncremto.Name = "txtIncremto";
            this.txtIncremto.Size = new System.Drawing.Size(154, 20);
            this.txtIncremto.TabIndex = 7;
            // 
            // btnPrecioCosto
            // 
            this.btnPrecioCosto.Location = new System.Drawing.Point(20, 2);
            this.btnPrecioCosto.Name = "btnPrecioCosto";
            this.btnPrecioCosto.Size = new System.Drawing.Size(99, 24);
            this.btnPrecioCosto.TabIndex = 8;
            this.btnPrecioCosto.Text = "% Precio costo";
            this.btnPrecioCosto.UseVisualStyleBackColor = true;
            this.btnPrecioCosto.Click += new System.EventHandler(this.btnPrecioCosto_Click);
            // 
            // txtIncremtoPC
            // 
            this.txtIncremtoPC.Location = new System.Drawing.Point(125, 5);
            this.txtIncremtoPC.Name = "txtIncremtoPC";
            this.txtIncremtoPC.Size = new System.Drawing.Size(154, 20);
            this.txtIncremtoPC.TabIndex = 9;
            // 
            // lblCantidadADescontar
            // 
            this.lblCantidadADescontar.AutoSize = true;
            this.lblCantidadADescontar.Location = new System.Drawing.Point(20, 65);
            this.lblCantidadADescontar.Name = "lblCantidadADescontar";
            this.lblCantidadADescontar.Size = new System.Drawing.Size(108, 13);
            this.lblCantidadADescontar.TabIndex = 10;
            this.lblCantidadADescontar.Text = "Cantidad a descontar";
            // 
            // txtBCantidadAdescontar
            // 
            this.txtBCantidadAdescontar.Location = new System.Drawing.Point(134, 63);
            this.txtBCantidadAdescontar.Name = "txtBCantidadAdescontar";
            this.txtBCantidadAdescontar.Size = new System.Drawing.Size(114, 20);
            this.txtBCantidadAdescontar.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 12;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(286, 72);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 13;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // MainProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBCantidadAdescontar);
            this.Controls.Add(this.lblCantidadADescontar);
            this.Controls.Add(this.txtIncremtoPC);
            this.Controls.Add(this.btnPrecioCosto);
            this.Controls.Add(this.txtIncremto);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.txbSearchProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.btnSearch);
            this.Name = "MainProducts";
            this.Text = "MainProducts";
            this.Load += new System.EventHandler(this.MainProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearchProduct;
        private System.Windows.Forms.BindingSource productocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.TextBox txtIncremto;
        private System.Windows.Forms.Button btnPrecioCosto;
        private System.Windows.Forms.TextBox txtIncremtoPC;
        private System.Windows.Forms.Label lblCantidadADescontar;
        private System.Windows.Forms.TextBox txtBCantidadAdescontar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombreProducto;
    }
}