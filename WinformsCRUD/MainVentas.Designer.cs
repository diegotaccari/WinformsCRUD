namespace WinformsCRUD
{
    partial class MainVentas
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
            this.lblDenominacionPro = new System.Windows.Forms.Label();
            this.lblCantidadVenta = new System.Windows.Forms.Label();
            this.txtBCantidadVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtBPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnVenta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbProductoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDenominacionPro
            // 
            this.lblDenominacionPro.AutoSize = true;
            this.lblDenominacionPro.Location = new System.Drawing.Point(52, 42);
            this.lblDenominacionPro.Name = "lblDenominacionPro";
            this.lblDenominacionPro.Size = new System.Drawing.Size(53, 13);
            this.lblDenominacionPro.TabIndex = 0;
            this.lblDenominacionPro.Text = " Producto";
            // 
            // lblCantidadVenta
            // 
            this.lblCantidadVenta.AutoSize = true;
            this.lblCantidadVenta.Location = new System.Drawing.Point(53, 85);
            this.lblCantidadVenta.Name = "lblCantidadVenta";
            this.lblCantidadVenta.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadVenta.TabIndex = 2;
            this.lblCantidadVenta.Text = "Cantidad ";
            // 
            // txtBCantidadVenta
            // 
            this.txtBCantidadVenta.Location = new System.Drawing.Point(134, 82);
            this.txtBCantidadVenta.Name = "txtBCantidadVenta";
            this.txtBCantidadVenta.Size = new System.Drawing.Size(125, 20);
            this.txtBCantidadVenta.TabIndex = 3;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(52, 134);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioVenta.TabIndex = 4;
            this.lblPrecioVenta.Text = "Precio";
            // 
            // txtBPrecioVenta
            // 
            this.txtBPrecioVenta.Location = new System.Drawing.Point(134, 130);
            this.txtBPrecioVenta.Name = "txtBPrecioVenta";
            this.txtBPrecioVenta.Size = new System.Drawing.Size(125, 20);
            this.txtBPrecioVenta.TabIndex = 5;
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(304, 35);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(115, 46);
            this.btnVenta.TabIndex = 6;
            this.btnVenta.Text = "Registar Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 215);
            this.dataGridView1.TabIndex = 7;
            // 
            // cmbProductoc
            // 
            this.cmbProductoc.FormattingEnabled = true;
            this.cmbProductoc.Location = new System.Drawing.Point(129, 42);
            this.cmbProductoc.Name = "cmbProductoc";
            this.cmbProductoc.Size = new System.Drawing.Size(129, 21);
            this.cmbProductoc.TabIndex = 8;
            this.cmbProductoc.SelectedIndexChanged += new System.EventHandler(this.cmbProductoc_SelectedIndexChanged);
            // 
            // MainVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbProductoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.txtBPrecioVenta);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.txtBCantidadVenta);
            this.Controls.Add(this.lblCantidadVenta);
            this.Controls.Add(this.lblDenominacionPro);
            this.Name = "MainVentas";
            this.Text = "MainVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDenominacionPro;
        private System.Windows.Forms.Label lblCantidadVenta;
        private System.Windows.Forms.TextBox txtBCantidadVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtBPrecioVenta;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbProductoc;
    }
}