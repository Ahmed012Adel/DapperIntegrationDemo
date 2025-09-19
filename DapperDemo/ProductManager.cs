using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    internal class ProductManager : IManager<Products>
    {
        SqlConnection DbConnection = new SqlConnection("Server = .; Database = Northwind ; Trusted_Connection = True; TrustServerCertificate = True;");
        public List<Products> GetAll()
            => DbConnection.Query<Products>("SelectAllProducts", commandType:
                System.Data.CommandType.StoredProcedure).ToList();

        public Products? GetById(int id)
            => DbConnection.QueryFirstOrDefault<Products>("Select * From products where ProductID = @ProductID",
                new { ProductID = id });

        public bool Add(Products entity)
           =>DbConnection.Execute("insert into products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) " +
            "values (@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder,@ReorderLevel,@Discontinued)", entity) > 0;

        public bool Delete(int id)
            => DbConnection.Execute("delete from products where ProductID = @ProductID",
                new {
                    ProductID = id 
                }) > 0;

        public bool Update(Products item)
         => DbConnection.Execute("UpdateProduct ", new
         {
             ProductName = item.productName,
             SupplierID = item.SupplierId,
             CategoryID = item.CategoryID,
             QuantityPerUnit = item.QuantityPerUnit,
             UnitPrice = item.UnitPrice,
             UnitsInStock = item.UnitsInStock,
             UnitsOnOrder = item.UnitsOnOrder,
             ReorderLevel = item.ReorderLevel,
             ProductID = item.ProductId,
             Discontinued = item.Discontinued
         }, commandType: System.Data.CommandType.StoredProcedure) > 0;
    }
}
