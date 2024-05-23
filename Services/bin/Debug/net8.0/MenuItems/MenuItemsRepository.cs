using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.Data.Sqlite;
using Repositories.Utilities;
using Dapper;

namespace Repositories.MenuItems
{
    public class MenuItemsRepository : IMenuItemsRepository
    {
        public void Add(MenuItem item)
        {
            using (IDbConnection conn = new SqliteConnection(DbUtility.LoadConnectionString()))
            {

            }
        }

        public IEnumerable<MenuItem> GetAll()
        {
            using (IDbConnection conn = new SqliteConnection(DbUtility.LoadConnectionString()))
            {
                string sql = "select * from MenuItems";
                var output = conn.Query<MenuItem>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        public MenuItem GetById(int id)
        {
            using (IDbConnection conn = new SqliteConnection(DbUtility.LoadConnectionString()))
            {
                return null;
            }
        }

        public void RemoveById(int id)
        {
            using (IDbConnection conn = new SqliteConnection(DbUtility.LoadConnectionString()))
            {

            }
        }

        /// <summary>
        /// Save a menu item to the database
        /// </summary>
        /// <param name="item">a menu item</param>
        public void Save(MenuItem item)
        {
            using (IDbConnection conn = new SqliteConnection(DbUtility.LoadConnectionString()))
            {
                string sql = "insert into MenuItems (Name, Price) values (@Name, @Price)";
                conn.Execute(sql, item);
            }
        }

        public void Update(MenuItem item)
        {
            using (IDbConnection conn = new SqliteConnection(DbUtility.LoadConnectionString()))
            {

            }
        }


    }
}
