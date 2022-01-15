using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db1 = new SqlDatabase()
            {
                Name = "Microsoft SQL Server",
                Company = "Microsoft",
                isRelational = true
            };
            db1.Create();

            SqlDatabase db2 = new SqlDatabase()
            {
                Name = "Microsoft SQL Server",
                Company = "Microsof",
                isRelational = true
            };
            db2.Create();
            db2.Update();

            Database db3 = new OracleDatabase()
            {
                Name = "Oracle",
                Company = "Oracle",
                isRelational = true
            };
            db3.Read();

            Console.ReadLine();
        }
    }

    class Database
    {
        public string Name { get; set; }
        public string Company { get; set; } // property

        public bool isRelational; // field
        public void Create() // behavior
        {
            Console.WriteLine("Created by Database.");
        }

        public virtual void Update()
        {
            Console.WriteLine("Updated by Database.");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Database.");
        }

        public virtual void Read()
        {
            Console.WriteLine("Read by Database.");
        }

    }

    class SqlDatabase : Database
    {
        public override void Update()
        {
            //base.Update();
            Console.WriteLine("Updated by Sql.");

        }
    }

    class OracleDatabase : Database
    {
        public override void Read()
        {
            Console.WriteLine("Read by Oracle.");
        }
    }
}
