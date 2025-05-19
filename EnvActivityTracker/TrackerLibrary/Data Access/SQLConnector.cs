using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Data;
using System.Runtime.CompilerServices;
using TrackerLibrary.Models;
using Dapper;
using System.Reflection;

namespace TrackerLibrary.Data_Access
{
    public static class SQLConnector
    {
        public static string connString = ConfigurationManager.ConnectionStrings["EnvTracker"].ConnectionString;

        public static void CreateEnvironment(EnvironmentModel model)
        {
            using (IDbConnection conn = new SqlConnection(connString))
            {
                var p = new DynamicParameters();

                p.Add("@EnvCode", model.EnvironmentCode);
                p.Add("@EnvName", model.EnvironmentName);
                p.Add("@EnvDetails", model.EnvironmentDetails);

                conn.Execute("dbo.spEnvironment_Insert",p,commandType: CommandType.StoredProcedure);
            }
        }

        public static bool IsUniqueEnvCode(string envCode)
        {
            using (IDbConnection conn = new SqlConnection(connString))
            {
                var p = new DynamicParameters();

                p.Add("@EnvCode", envCode);
                p.Add("@CurrEnvCode","", dbType: DbType.String, direction: ParameterDirection.Output);

                conn.Execute("dbo.spEnvironment_CheckCode", p, commandType: CommandType.StoredProcedure);

                return p.Get<string>("@CurrEnvCode") is null;
            }
        }
    }
}
