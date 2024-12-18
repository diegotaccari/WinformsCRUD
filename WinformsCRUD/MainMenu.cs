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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

    

        private void btnContacts_Click(object sender, EventArgs e)
        {
           
           OpenMainContacs();

        }
         private void OpenMainContacs ()
        {
            MainContacts mainContacs = new MainContacts();
            mainContacs.ShowDialog(this);
        }

        private void btnProdyucts_Click(object sender, EventArgs e)
        {
            OpenMainProducts();
        }

        private void OpenMainProducts()
        {
            MainProducts mainProducts = new MainProducts();
            mainProducts.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            OpenMianVentas();
        }
        private void OpenMianVentas()
        {
            MainVentas mainVentas = new MainVentas();
            mainVentas.ShowDialog(this);
        }
    }
}
