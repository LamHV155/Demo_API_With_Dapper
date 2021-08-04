using azicloud.wiki.bo.Interfaces;
using azicloud.wiki.Dtos;
using azicloud.wiki.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azicloud.wiki.Repositories
{
    public class WikiCategoryService : IWikiCategoryService
    {
        private readonly Iwiki_category _category;
        public WikiCategoryService(Iwiki_category category)
        {
            _category = category;
        }

        public async Task<int> Create1(PostWikiCategoryDto req)
        {
            var res = await _category.wiki_category_Create1(req.Id, req.uId, req.parent_id, req.image_id, req.name, req.description);
            var rs = res.Read<int>().FirstOrDefault();
            return rs;
        }

        public async Task<int> Delete1(long intId, long uId)
        {
            var res = await _category.wiki_category_Delete1(intId, uId);
            var rs = res.Read<int>().FirstOrDefault();
            return rs;
        }

        public async Task<List<GetWikiCategoriesDto>> Filter_Rows1()
        {
            var categories = new List<GetWikiCategoriesDto>();
            var res = await _category.wiki_category_Filter_Rows1();
            
           categories = res.Read<GetWikiCategoriesDto>().ToList();
           return categories;
        }
    }
}
