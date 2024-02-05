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
    public partial class MainContacts : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public MainContacts()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenContactDetailDialog();
        }
        #region PRIVATE METHOS 
        private void OpenContactDetailDialog()
        {
            ContacDetails contacDetails = new ContacDetails();
            contacDetails.ShowDialog(this);
        }
        #endregion

        private void Main_Load_1(object sender, EventArgs e)
        {
            PopulateContas();
        }

        public void PopulateContas(string searchText = null)
        {
            List<Contact> contacs = _businessLogicLayer.GetContacts(searchText);
            GridContacts.DataSource = contacs;
        }

        private void GridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             DataGridViewLinkCell cell = (DataGridViewLinkCell)GridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Edit")
            {
                ContacDetails contacDetails = new ContacDetails();
                contacDetails.LoadContact(new Contact
                {
                    // buenas practica y arquitectura de solucuines 
                    Id = int.Parse(GridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FirstName = GridContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = GridContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone = GridContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address = GridContacts.Rows[e.RowIndex].Cells[4].Value.ToString()
                });
                contacDetails.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete")
            {

                DeleteContact(int.Parse(GridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopulateContas();
            }
        }
        private void DeleteContact(int id)
        {
            _businessLogicLayer.DeleteContact(id);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateContas(txtSearch.Text);
            txtSearch.Text = string.Empty;
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
