using System.Data;

namespace adapter_pattern.LegacyStuff
{
    public class FootballerProvider
    {
        public DataTable LegacyFootballerProvider()
        {
            DataTable dataTable = new();
            dataTable.Columns.Add(new DataColumn ("Team") { Caption = "Team", DataType = typeof(string) });
            dataTable.Columns.Add(new DataColumn ("Name") { Caption = "Name", DataType = typeof(string) });
            dataTable.Columns.Add(new DataColumn ("BirthDate") { Caption = "BirthDate", DataType = typeof(DateTime) });
            dataTable.Columns.Add(new DataColumn ("Position") { Caption = "Position", DataType = typeof(string) });

            var dataSet = new DataSet();

            dataSet.Tables.Add(dataTable);

            DataRow row;

            for (int i = 0; i <= 2; i++)
            {
                row = dataTable.NewRow();
                row["Team"] = "Barcelona";
                row["Name"] = "Pedri" + i;
                row["BirthDate"] = DateTime.Now;
                row["Position"] = "Midfielder";
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
