using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class sqlbaglantisi
    {
        public string baglanti = System.IO.File.ReadAllText(@"C:\Proje_HastaneDb.txt");
    }
}
