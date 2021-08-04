using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azicloud.wiki.bo.Interfaces
{
    public interface IDapperService
    {
        Task<SqlMapper.GridReader> ExecuteSpGirdReader(string sp, DynamicParameters parms);
    }
}
