using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinformsCRUD.BusinessLogicLayer;
using static WinformsCRUD.DataAccesLayer;

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
        public class ProductoBLL
        {
            public void ActualizarPrecios(decimal porcentaje)
            {
                decimal factorAumento = 1 + (porcentaje / 100);
                ProductoDAL productoDAL = new ProductoDAL();
                productoDAL.ActualizarPrecios(factorAumento);
            }
        }
        public class ProductoBLLPC
        {
            public void ActualizarPreciosCosto(decimal porcentaje)
            {
                decimal factorAumento = 1 + (porcentaje / 100);
                ProductoDALPC productoDALPrecioCosto = new ProductoDALPC();
                productoDALPrecioCosto.ActualizarPreciosPrecioCosto(factorAumento);
            }
        }

        public void AplicarDescuentoProducto(string denominacion, int cantidadDescuento)
        {
            _dataAccessLayer.AplicarDescuentoProducto(denominacion, cantidadDescuento);
        }
    }
}
