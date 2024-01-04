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
    public partial class ContacDetails : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        private Contact _contact; 
        public ContacDetails()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveContact();
            this.Close();
           ((Main) this.Owner).PopulateContas();
        }

        private void SaveContact()
        {
            Contact contact = new Contact();
            contact.FirstName = TxtFristName.Text;
            contact.LastName = TxtLastName.Text;
            contact.Phone = TxtPhone.Text;
            contact.Address = TxtAddress.Text;
            
            contact.Id = _contact != null ? _contact.Id : 0;

            _businessLogicLayer.SaveContact(contact);
        }

        public void LoadContact (Contact contact)
        {
            _contact = contact;
            if (contact != null) 
            {
                ClearForm();

                TxtFristName.Text = contact.FirstName;
                TxtLastName.Text = contact.LastName; 
                TxtPhone.Text = contact.Phone;
                TxtAddress.Text = contact.Address;
            }

        }
        private void ClearForm()
        {
            TxtFristName.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtAddress.Text = string.Empty;
        }
    }
}
