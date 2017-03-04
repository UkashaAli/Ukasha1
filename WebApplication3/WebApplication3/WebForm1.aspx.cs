using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetChartData();
                GetChartTypes();
            }
        

        }
        private void GetChartData()
        {
            string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select Student Name, Total Marks from Students", con);
                Series series = Chart2.Series["Series1"];
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read()){
                    series.Points.AddXY(rdr["Student Name"].ToString(), rdr["Total Marks"]);
                }
            }
        }
        private void GetChartTypes()
        {
            foreach(int chartType in Enum.GetValues(typeof(SeriesChartType)))
            {
                ListItem li = new ListItem(Enum.GetName(typeof(SeriesChartType), chartType), chartType.ToString());
                DDL1.Items.Add(li);
            }
        }

        protected void DDL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetChartData();
            Chart2.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), DDL1.SelectedValue);
        }
    }
}