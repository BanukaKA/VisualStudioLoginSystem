using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LoginSystemBKA
{
    class Connect
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='F:\C#\LoginSystemBKA\LoginSystemBKA\Databases\Data.mdf';Integrated Security=True;Connect Timeout=30";

    }
}
