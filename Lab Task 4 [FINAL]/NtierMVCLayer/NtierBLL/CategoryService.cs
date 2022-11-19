using NtierBLL.DTO;
using NtierDLL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierBLL
{
    public class CategoryService
    {
        public static List<CategoryDTO> GetAll()
        {
            var cat = new List<CategoryDTO>();

            var dbnews = new CategoryRepo().Get();
            foreach (var item in dbnews)
            {

                cat.Add(new CategoryDTO() { Cid=item.Cid,cname=item.cname});

            }
            return cat;

        }
    }
}
