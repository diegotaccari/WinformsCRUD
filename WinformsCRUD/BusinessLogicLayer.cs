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

        public Productoc SaveProductoc (Productoc productoc)
        {
            if (productoc.Id == 0)
                _dataAccessLayer.InsertProductoc(productoc);
            else
                _dataAccessLayer.UpdateProductoc(productoc);

            return productoc;
        }
        public List<Productoc> GetProductocs( string searchText = null)
        {
           return _dataAccessLayer.GetProductoc(searchText);
        }

        public void DeleteProductoc(int id) 
        {
            _dataAccessLayer.DeleteProduct(id);
        }

    }
}
