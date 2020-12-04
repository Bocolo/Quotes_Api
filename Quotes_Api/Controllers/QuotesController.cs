using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Quotes_Api.Data;
using Quotes_Api.Models;

namespace Quotes_Api.Controllers
{
    public class QuotesController : ApiController
    {
        QuotesDbContext quotesDbContext = new QuotesDbContext();
        // GET: api/Quotes
        //used to retuen qotes from the database
        public IEnumerable<Quotes> Get()
        {
            return quotesDbContext.Quotes;
        }

        // GET: api/Quotes/5
        // return singular quote against id
        public Quotes Get(int id)
        {
             var quote = quotesDbContext.Quotes.Find(id);
            return quote;
        }

        // POST: api/Quotes
        public void Post([FromBody]Quotes quote)
        {
            quotesDbContext.Quotes.Add(quote);
            quotesDbContext.SaveChanges();
        }

        // PUT: api/Quotes/5
        public void Put(int id, [FromBody] Quotes quote)
        {
            var entity = quotesDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            quotesDbContext.SaveChanges();
        }

        // DELETE: api/Quotes/5
        public void Delete(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            quotesDbContext.Quotes.Remove(quote);
            quotesDbContext.SaveChanges();
        }
    }
}
