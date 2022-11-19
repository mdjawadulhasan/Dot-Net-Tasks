using NtierDLL.EF;
using NtierDLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierDLL.Repo
{
    public class CategoryRepo : IRepo<Category, int>
    {
        public void Add(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get()
        {
            var db = new NewsTaskEntities();
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
