using NtierDLL.EF;
using NtierDLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierDLL.Repo
{
    public class NewsRepo : IRepo<News,int>
    {
        public void Add(News obj)
        {
            var db = new NewsTaskEntities();
            db.News.Add(obj);
            db.SaveChanges();
        }


       

        public List<News> Get()
        {
            var db = new NewsTaskEntities();
            return db.News.ToList();
        }

        

        public News Get(int id)
        {
            var db = new NewsTaskEntities();
            return db.News.FirstOrDefault(x => x.id.Equals(id));
        }

        public void Update(News obj)
        {
            var db = new NewsTaskEntities();
            var existingnews = db.News.Where(temp => temp.id == obj.id).FirstOrDefault();
            existingnews.id = obj.id;
            existingnews.Title = obj.Title;
            existingnews.CatId = obj.CatId;
            existingnews.Date = obj.Date;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var db = new NewsTaskEntities();
            var existingnews = db.News.Where(temp => temp.id == id).FirstOrDefault();
            db.News.Remove(existingnews);
            db.SaveChanges();
        }
    }

}
