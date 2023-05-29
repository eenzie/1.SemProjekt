using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Repositories {

    /// <summary>
    /// This will be the base database that will define the connection string to the server
    /// </summary>
    public abstract class Database_Abstract {
        protected readonly string ConnectionString = @"Server=mssql3.unoeuro.com;Database=tripshop_dk_db_project;User Id=tripshop_dk;Password=wDafdGbx6ynAkcRzprmt;TrustServerCertificate=True";
    }
}
