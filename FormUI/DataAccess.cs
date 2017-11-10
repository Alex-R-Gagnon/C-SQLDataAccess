using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccess
    {
        public List<Company> GetCompany(string ticker)
        {
            //throw new NotImplementedException();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TickerDB")))
            {
                //return connection.Query<Company>($"select * from Company where Ticker = '{ ticker }'").ToList(); // Calls direct SQL
                return connection.Query<Company>("dbo.Tickers @ Ticker", new { Ticker = ticker }).ToList(); // Calls Stored Procedure
            }
        }

        public void AddCompany(string ticker, string companyName, int volume, bool optionable, string website)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TickerDB")))
            {
                List<Company> company = new List<Company>();

                company.Add(new Company { Ticker = ticker, CompanyName = companyName, Volume = volume, Optionable = optionable, Website = website });

                connection.Execute("dbo.Comapany_Insert @Ticker, @CompanyName, @Volume, @Optionable, @Website", company);
            }
        }
    }
}
