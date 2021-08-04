using azicloud.wiki.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azicloud.wiki.Interfaces
{
    public interface IWikiCategoryService
    {
       Task<List<GetWikiCategoriesDto>> Filter_Rows1();
       Task<int> Create1(PostWikiCategoryDto req);
        Task<int> Delete1(long intId, long uId);
    }
}
