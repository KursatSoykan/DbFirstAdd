using DbFirstAdd.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstAdd.Services
{
    public class SupplierService
    {
        Supplier suppliers = new Supplier();

        public void DeleteSupplier(int id)
        {
            NorthwndContext context=new NorthwndContext();
            var supllierid = context.Suppliers.FirstOrDefault(x => x.SupplierId == id);
            context.Suppliers.Remove(supllierid);
            context.SaveChanges();
        }
        public List<Supplier> GetSuppliers()
        {
            NorthwndContext context = new NorthwndContext();
            List<Supplier> suppliersList = context.Suppliers.ToList();
            return suppliersList;


        }






    }
}
