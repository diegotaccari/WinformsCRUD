﻿using System;
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
    public partial class MainProducts : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public MainProducts()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            OpenContactDetailDialog();
        }
        private void OpenContactDetailDialog()
        {
            ProdutcDetails productDetails = new ProdutcDetails();
            productDetails.ShowDialog(this);
        }

        private void MainProducts_Load(object sender, EventArgs e)
        {
            PopularProducts();
        }
        public void PopularProducts(string searchText = null)
        {
            List<Productoc> productocs = _businessLogicLayer.GetProductocs(searchText);
            gridProducts.DataSource = productocs;
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridProducts.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString()== "Edit")
            {
                ProdutcDetails produtcDetails = new ProdutcDetails();
                produtcDetails.LoadProductoc(new Productoc
                {
                    Id =int.Parse(gridProducts.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Denominacion = gridProducts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    PrecioVenta = decimal.Parse(gridProducts.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    PrecioCosto = decimal.Parse(gridProducts.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    Stock = int.Parse(gridProducts.Rows[e.RowIndex].Cells[4].Value.ToString()),
                });
                produtcDetails.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete")
            {
                DeleteProducts(int.Parse(gridProducts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopularProducts();
            }
        }
        private void DeleteProducts(int id)
        {
            _businessLogicLayer.DeleteProductoc(id);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopularProducts(txbSearchProduct.Text);
            txbSearchProduct.Text = string.Empty;
        }
    }
}