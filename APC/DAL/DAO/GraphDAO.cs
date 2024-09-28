using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class GraphDAO:APCContexts
    {
        public string SelectAmountRaised(int year)
        {
            List<decimal> dues = new List<decimal>();
            decimal summedUP = 0;
            var list = db.PERSONAL_ATTENDANCE.Where(x => x.isDeleted == false && x.year == year).ToList();
            foreach (var item in list)
            {
                if (item.monthlyDues > 0)
                {
                    summedUP += (decimal)item.monthlyDues;
                }
            }

            return summedUP.ToString();

            //string monthlyDues = "SELECT PERSONAL_ATTENDANCE.monthID, SUM(PERSONAL_ATTENDANCE.monthlyDues)" +
            //"FROM PERSONAL_ATTENDANCE" +
            //"WHERE PERSONAL_ATTENDANCE.year = @year AND PERSONAL_ATTENDANCE.isDeleted = 0" +
            //"GROUP BY PERSONAL_ATTENDANCE.monthID" +
            //"ORDER BY PERSONAL_ATTENDANCE.monthID ASC";
            //return monthlyDues.Replace("@year", year.ToString());
        }
    }
}
