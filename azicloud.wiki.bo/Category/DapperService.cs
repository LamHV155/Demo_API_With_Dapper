using azicloud.wiki.bo.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azicloud.wiki.bo.Category
{
    public class DapperService : IDapperService
    {
        private readonly string _conStr;
        public DapperService(string conStr)
        {
            _conStr = conStr;
        }
        public async Task<SqlMapper.GridReader> ExecuteSpGirdReader(string sp, DynamicParameters parms)
        {
            IDbConnection cnn = new SqlConnection(_conStr);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                SqlMapper.GridReader grid = await cnn.QueryMultipleAsync(sp, parms, commandType: CommandType.StoredProcedure);
                return grid;
            }
            catch
            {
                return null;
            }

        }
    }
}
