using System.Data;
using System.IO;

namespace JsonSamples
{
    public class Generate
    {
        public static string SingleJson()
        {
            return File.ReadAllText("AuthorSingle.json");
        }

        public static DataSet CoursesDataSet()
        {
            DataSet dataSet = new DataSet("Courses");
            DataTable table = new DataTable();
            DataColumn idColumn = new DataColumn("id", typeof(int));
            idColumn.AutoIncrement = true;

            DataColumn itemColumn = new DataColumn("name", typeof(string));
            table.Columns.Add(idColumn);
            table.Columns.Add(itemColumn);
            dataSet.Tables.Add(table);

            string[] courses = new string[] { "Solr", "Spark", "Jira" };
            foreach(var course in courses)
            {
                DataRow newRow = table.NewRow();
                newRow["name"] = course;
                table.Rows.Add(newRow);
            }

            dataSet.AcceptChanges();
            return dataSet;
        }

        public static string DatesJson()
        {
            return File.ReadAllText("AuthorDates.json");
        }

    }
}
