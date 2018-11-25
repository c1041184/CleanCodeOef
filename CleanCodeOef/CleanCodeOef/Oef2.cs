using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeOef
{
    class Oef2
    {
        //class MySQLConnection
        //{
        //}
        //class PasswordReminder
        //{
        //    private MySQLConnectoin dbConnection;
        //    public PasswordReminder(MySQLConnectoin con)
        //    {
        //        dbConnection = con;
        //    }
        //}

        // OCP 
        //als men een andere Database connectie wil, Moet men de classes aanpassen

        public interface IdbConnection
        {
        }

        class MySQLConnection : IdbConnection
        {
        }

        class MsSQLConnection : IdbConnection
        {
        }

        class PasswordReminder
        {
            private IdbConnection dbConnection;
            public PasswordReminder(IdbConnection con)
            {
                dbConnection = con;
            }
        }

        public void Main()
        {
            PasswordReminder prMySql = new PasswordReminder(new MySQLConnection());
            PasswordReminder prMsSql = new PasswordReminder(new MsSQLConnection());
        }

    }
}
