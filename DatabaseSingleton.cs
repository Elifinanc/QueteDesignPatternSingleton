using System;
using System.Collections.Generic;
using System.Text;

namespace QueteSingleton
{
    public class DatabaseSingleton
    {
        private static DatabaseSingleton _database;

        private DatabaseSingleton()
        {
            Console.WriteLine("On créé l'objet 1 fois!");
        }

        public static DatabaseSingleton Database
        {
            get
            {
                if (_database == null) 
                {
                    _database = new DatabaseSingleton();
                }
                return _database;
            }
        }
    }
}
