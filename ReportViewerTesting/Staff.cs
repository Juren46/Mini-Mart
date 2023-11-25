using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportViewerTesting
{
    public  class Staff
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static DataTable GetStaffDataTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add ("Name", typeof(string));

            table.Rows.Add(1, "Trung");
            table.Rows.Add(2, "Tin");
            table.Rows.Add(3, "Anh");

            return table;
        }
    }
}
