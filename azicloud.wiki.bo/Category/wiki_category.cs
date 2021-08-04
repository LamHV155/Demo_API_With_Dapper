using azicloud.wiki.bo.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azicloud.wiki.bo.Category
{
    public class wiki_category : Iwiki_category
    {
        private readonly IDapperService _dapper;
       public wiki_category(IDapperService dapper)
        {
            _dapper = dapper;
        }

        public async Task<SqlMapper.GridReader> wiki_category_Create1(int Id, long uId, long parent_id, long image_id, string name, string description)
        {
            var parms = new DynamicParameters();
            parms.Add("Id", Id, DbType.Int64);
            parms.Add("uId", uId, DbType.Int64);
            parms.Add("parent_id", parent_id, DbType.Int64);
            parms.Add("image_id", image_id, DbType.Int64);
            parms.Add("name", name, DbType.String);
            parms.Add("description", description, DbType.String);
            var res = await _dapper.ExecuteSpGirdReader("dbo.wiki_category_Create1", parms);
            return res;
        }

        public async Task<SqlMapper.GridReader> wiki_category_Delete1(long intId, long uId)
        {
            var parms = new DynamicParameters();
            parms.Add("intId", intId, DbType.Int64);
            parms.Add("uId", uId, DbType.Int64);

            var res = await _dapper.ExecuteSpGirdReader("dbo.wiki_category_Delete1", parms);
            return res;
        }

        public async Task<SqlMapper.GridReader> wiki_category_Filter_Rows1()
        {
            var res = await _dapper.ExecuteSpGirdReader("dbo.wiki_category_Filter_Rows1", new DynamicParameters());
            return res;    
        }
    }
}
