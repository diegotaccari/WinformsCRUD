namespace WinformsCRUD
{
    partial class ProdutcDetails
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
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.txtBStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtBPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtBPrecioCosto = new System.Windows.Forms.TextBox();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.btnSaveProductoc = new System.Windows.Forms.Button();
            this.btnCancelProductoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denominacion";
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(148, 35);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(115, 20);
            this.txtDenominacion.TabIndex = 1;
            // 
            // txtBStock
            // 
            this.txtBStock.Location = new System.Drawing.Point(148, 162);
            this.txtBStock.Name = "txtBStock";
            this.txtBStock.Size = new System.Drawing.Size(115, 20);
            this.txtBStock.TabIndex = 5;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(68, 165);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            // 
            // txtBPrecioVenta
            // 
            this.txtBPrecioVenta.Location = new System.Drawing.Point(148, 115);
            this.txtBPrecioVenta.Name = "txtBPrecioVenta";
            this.txtBPrecioVenta.Size = new System.Drawing.Size(115, 20);
            this.txtBPrecioVenta.TabIndex = 7;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(53, 122);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(68, 13);
            this.lblPrecioVenta.TabIndex = 6;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // txtBPrecioCosto
            // 
            this.txtBPrecioCosto.Location = new System.Drawing.Point(148, 78);
            this.txtBPrecioCosto.Name = "txtBPrecioCosto";
            this.txtBPrecioCosto.Size = new System.Drawing.Size(115, 20);
            this.txtBPrecioCosto.TabIndex = 9;
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Location = new System.Drawing.Point(53, 81);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(67, 13);
            this.lblPrecioCosto.TabIndex = 8;
            this.lblPrecioCosto.Text = "Precio Costo";
            // 
            // btnSaveProductoc
            // 
            this.btnSaveProductoc.Location = new System.Drawing.Point(103, 224);
            this.btnSaveProductoc.Name = "btnSaveProductoc";
            this.btnSaveProductoc.Size = new System.Drawing.Size(85, 27);
            this.btnSaveProductoc.TabIndex = 10;
            this.btnSaveProductoc.Text = "Save";
            this.btnSaveProductoc.UseVisualStyleBackColor = true;
            this.btnSaveProductoc.Click += new System.EventHandler(this.btnSaveProductoc_Click);
            // 
            // btnCancelProductoc
            // 
            this.btnCancelProductoc.Location = new System.Drawing.Point(207, 224);
            this.btnCancelProductoc.Name = "btnCancelProductoc";
            this.btnCancelProductoc.Size = new System.Drawing.Size(85, 27);
            this.btnCancelProductoc.TabIndex = 11;
            this.btnCancelProductoc.Text = "Cancel";
            this.btnCancelProductoc.UseVisualStyleBackColor = true;
            this.btnCancelProductoc.Click += new System.EventHandler(this.btnCancelProductoc_Click);
            // 
            // ProdutcDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelProductoc);
            this.Controls.Add(this.btnSaveProductoc);
            this.Controls.Add(this.txtBPrecioCosto);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.txtBPrecioVenta);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.txtBStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.label1);
            this.Name = "ProdutcDetails";
            this.Text = "ProdutcDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.TextBox txtBStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtBPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtBPrecioCosto;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Button btnSaveProductoc;
        private System.Windows.Forms.Button btnCancelProductoc;
    }
}