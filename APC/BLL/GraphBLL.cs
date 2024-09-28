using APC.DAL.DAO;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace APC.BLL
{
    public class GraphBLL
    {
        GraphDAO dao = new GraphDAO();

        public void SelectAmountRaised(int newYear, Chart newChart, System.Windows.Forms.Label title)
        {
            string amountRaised = dao.SelectAmountRaised(newYear);
            SqlParameter[] amountRaisedQueryYearlyParameters = new SqlParameter[]
            {
                new SqlParameter("@year", SqlDbType.Int) { Value = newYear}
            };
            General.CreateChart(newChart, amountRaised, amountRaisedQueryYearlyParameters, SeriesChartType.Pie, "Amount Raised", "");
            title.Text = "Amount Raised in " + newYear;
        }
    }
}
