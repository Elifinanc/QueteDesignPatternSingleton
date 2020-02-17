using System;
using System.Collections.Generic;
using System.Text;

namespace QueteSingleton
{
    class AnotherBank
    {
        private string _name;
        private DatabaseSingleton Database = DatabaseSingleton.Database;
    }
}
