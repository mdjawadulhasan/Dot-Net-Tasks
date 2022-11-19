using NtierBLL.DTO;
using NtierDLL.EF;
using NtierDLL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierBLL
{
    public class NewsService
    {

        public static void AddNews(NewsDTO nd)
        {
            var news = new News();
            news.Title = nd.Title;
            news.Date = nd.Date;
            news.CatId = nd.CatId;
            NewsRepo nrepo = new NewsRepo();
            nrepo.Add(news);

        }

        public static NewsDTO GetNews(int id)
        {
            NewsDTO news = null;
            var dbUser = new NewsRepo().Get(id);
            if (dbUser != null)
            {
                news = new NewsDTO();
                news.id = dbUser.id;
                news.Title = dbUser.Title;
                news.CatId = dbUser.CatId;
                news.Date = dbUser.Date;

            }

            return news;
        }


        public static List<NewsDTO> GetAll()
        {

            var confif = new MapperConfiguration();








            var news = new List<NewsDTO>();

            var dbnews = new NewsRepo().Get();
            foreach (var item in dbnews)
            {

                news.Add(new NewsDTO() { id = item.id, Title = item.Title, CatId = item.CatId, Date = item.Date });

            }
            return news;

        }



        public static void UpdateNews(NewsDTO nd)
        {
            var news = new News();
            news.id = nd.id;
            news.Title = nd.Title;
            news.Date = nd.Date;
            news.CatId = nd.CatId;
            NewsRepo nrepo = new NewsRepo();
            nrepo.Update(news);

        }


        public static void Delete(NewsDTO nd)
        {
            
            NewsRepo nrepo = new NewsRepo();
            nrepo.Delete(nd.id);

        }

    }
}
