using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsCRUD
{
    public partial class ProdutcDetails : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        private Productoc _productoc;
        public ProdutcDetails()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
            
        }

       

        private void btnCancelProductoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveProductoc_Click(object sender, EventArgs e)
        {
            SaveProdructoc();
            this.Close();
            ((MainProducts)this.Owner).PopularProducts();
        }

        private void SaveProdructoc()
        {
            Productoc productoc = new Productoc();
            productoc.Denominacion = txtDenominacion.Text;
            productoc.PrecioVenta = decimal.Parse(txtBPrecioVenta.Text);
            productoc.PrecioCosto = decimal.Parse(txtBPrecioCosto.Text);
            productoc.Stock = int.Parse(txtBStock.Text);

            productoc.Id = _productoc != null ? _productoc.Id : 0;

            _businessLogicLayer.SaveProductoc(productoc);
        }

        public void LoadProductoc(Productoc productoc)
        {
            _productoc = productoc;
            if (productoc != null) 
            {
                ClearmForm();
                txtDenominacion.Text = productoc.Denominacion;
                txtBPrecioVenta.Text = productoc.PrecioVenta.ToString();
                txtBPrecioCosto.Text = productoc.PrecioCosto.ToString();
                txtBStock.Text = productoc.Stock.ToString();
            }
        }
        private void ClearmForm()
        {
            txtDenominacion.Text = string.Empty;
            txtBPrecioVenta.Text = string.Empty;
            txtBPrecioCosto.Text = string.Empty;
            txtBStock.Text = string.Empty; 
        }
    }
}
