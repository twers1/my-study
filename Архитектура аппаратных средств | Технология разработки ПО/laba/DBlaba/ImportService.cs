using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBlaba
{
    public class ImportService
    {
        SqlConnectionStringBuilder connectionStringBuilder= new SqlConnectionStringBuilder(@"Data Sourse = C:\Users\Admin\source\repos\DBlaba\DBlaba\productDB.mdf");
        public ImportService(string[] dirPaths, string fileExt)
        {
            int n = dirPaths.Length;

        }

       
    }

    public class ImportTask : Runnable
    {
        public ImportTask(string dirPath, string fileExt)
        {

        }
    }
}
