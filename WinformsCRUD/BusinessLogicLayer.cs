using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsCRUD
{
    public class BusinessLogicLayer
    {
        private DataAccesLayer _dataAccessLayer;
        public BusinessLogicLayer() 
        { 
         _dataAccessLayer = new DataAccesLayer();
        }
        public Contact SaveContact (Contact contact) 
        {
            if (contact.Id == 0)
                _dataAccessLayer.InsertContac(contact);
            else
                _dataAccessLayer.UpdateContact(contact);

            return contact;
        }
        public List<Contact> GetContacts( string searchText = null)
        {
           return _dataAccessLayer.GetContacts(searchText);
        }
        public void DeleteContact (int id)
        {
            _dataAccessLayer.DeleteContact(id);
        }
    }
}
