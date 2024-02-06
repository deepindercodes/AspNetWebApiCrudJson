using AspNetWebApiCrudJson.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace AspNetWebApiCrudJson.Controllers
{
    public class ArticlesController : ApiController
    {
        jsonData objarticles = new jsonData();
        
        // GET: api/Articles
        public IEnumerable<Article> Get()
        {
            return objarticles.GetArticles();
        }

        // GET api/values/5
        public Article Get(int id)
        {
            return objarticles.GetArticles().Where(u => u.id == id.ToString()).FirstOrDefault();
        }

        // POST: api/Articles
        [HttpPost]
        public string Post([FromBody]Article article)
        {
            objarticles.AddArticle(article);
            return "{ status : 'New Article Added'}";
        }

        // PUT: api/Articles/5
        public string Put(int id, [FromBody] Article article)
        {
            objarticles.EditArticle(article, id);
            return "{ status : 'Article Edited'}";
        }

        // DELETE: api/Articles/5
        public string Delete(int id)
        {
            objarticles.DeleteArticle(id.ToString());
            return "{ status : 'Article Deleted'}";
        }
    }
}
