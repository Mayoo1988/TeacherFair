using GenericUtility.SqlDBAccess;
using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherApp.core;
using TeacherApp.Infrastructure;

namespace TeacherApp.Infrastructure
{
    public class ProductContext
    {
       
        public bool AddNewEmployee(Product employee)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", employee.Name),
                new SqlParameter("@Price", employee.Price),
                new SqlParameter("@Instock", employee.Instock )  
            };
            return SqlDbHelper.ExecuteNonQuery("Insertproducts", CommandType.StoredProcedure, parameters);
            
        }
    }
}
    

