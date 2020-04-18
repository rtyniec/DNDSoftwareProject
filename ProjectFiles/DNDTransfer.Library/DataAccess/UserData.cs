using DNDTransfer.Library.Internal.DataAccess;
using DNDTransfer.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDTransfer.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)//list of user model from the database by the ID
        {
            SqlDataAccess sql = new SqlDataAccess();//no dependency injection here

            var p = new { Id = Id };//ok so we pass a parameter here, which is the ID
            //only use dynamic for one assembly
            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "DNDData");//pass in our stored procedure, parameters, and database string name

            return output;//return a list of UserModel Model


        }
    }
}
