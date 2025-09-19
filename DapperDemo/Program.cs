using Dapper;
using Microsoft.Data.SqlClient;

namespace DapperDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection 
                = new SqlConnection("Server = .; Database = Northwind ; Trusted_Connection = True; TrustServerCertificate = True;");


            #region Query 
            // Retrive Data
            //var Result = connection.Query<Products>("select * from Products");

            // sp
            //var Result = connection.Query<Products>("SelectAllProducts", commandType: 
            //    System.Data.CommandType.StoredProcedure); 

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.productName);
            //}

            #endregion

            #region Execute

            //var compelet =   connection.Execute("Update products set ProductName = @productName where ProductID = @ProductID",
            //                     new 
            //                     { 
            //                         productName = "Ice Tea",
            //                         ProductID = 1 
            //                     });
            //var Compelet = connection.Execute("UpdateProductNameByProductID" , new
            //{
            //    productName = "Tea",
            //    ProductID = 1
            //},
            // commandType: System.Data.CommandType.StoredProcedure);
            //if (Compelet > 0)
            //    Console.WriteLine("Update Done");
            //else
            //    Console.WriteLine("Not Update");

            #endregion

            ProductManager productManager = new ProductManager();

            #region Add Product

            //Products product = new Products()
            //{
            //    productName = "IceMocha",
            //    SupplierId = 1,
            //    CategoryID = 1,
            //    QuantityPerUnit = "20 g",
            //    UnitPrice = 10,
            //    UnitsInStock = 15,
            //    UnitsOnOrder = 10,
            //    ReorderLevel = 5,
            //};
            //var isAdd = productManager.Add(product);
            //if(isAdd is true) Console.WriteLine("Product Added");
            //else Console.WriteLine("Failed Addded Product");
            #endregion

            #region Get All

            //var Result = productManager.GetAll().Count;
            //Console.WriteLine(Result);

            #endregion

            #region Gat By Id 

            //var Result = productManager.GetById(90);

            //Console.WriteLine(Result.productName);

            #endregion

            #region Update Product

            //var result = productManager.GetById(90);

            //result.productName = "Ice tea";
            //result.UnitPrice = 80;
            //Console.WriteLine(productManager.Update(result));
            #endregion

            #region Delete Product

            //var isDelete = productManager.Delete(90);
            //Console.WriteLine(isDelete ? "done" : "faild");
            #endregion
        }
    }
}
