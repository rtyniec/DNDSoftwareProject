using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDTransfer.Library.Internal.DataAccess
{
    internal class SqlDataAccess
    {
        public string GetConnectionString(string name)//we pass the name of the connection string found in the web.config file in the API
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;//goes to web.config, gets connection string w/ matching name, and returns it
            //this proj does not have a connection string. It has to run through a website that has the config file, or in this case our API
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)//we can pass in whatever stored procedure we create? awesome
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {//this is where we start using dapper, which has been added to our class library references
                List<T> rows = connection.Query<T>(storedProcedure, parameters,//T is the type of model I want each row to be
                    commandType: CommandType.StoredProcedure).ToList();//return a set of rows below

                return rows;
            }
        }

        //we use <T> for generics
        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)//we can pass in whatever stored procedure we create? awesome
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters,//T is the type of model I want each row to be
                    commandType: CommandType.StoredProcedure);//return a set of rows below
            }
        }//watch videos about generics, connecting c# to sql, and dapper vids


    }
}
