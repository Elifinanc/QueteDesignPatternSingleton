using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

namespace QueteSingleton
{
    class bank
    {
        private string _name;
        private DatabaseSingleton Database=DatabaseSingleton.Database;
    }
}
