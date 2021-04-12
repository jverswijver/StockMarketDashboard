using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "Defualt")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<UserModel> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from user", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User(_UserName, _Password) values (@_UserName, @_Password)", user);
            }
        }




    }


    class UserModel
    {
        public int Id { get; set; }
        public string _UserName { get; set; }

        public string _Password { get; set; }

    }
}
