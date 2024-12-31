using Microsoft.AspNetCore.Mvc;
using System.Drawing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sale123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftsController : ControllerBase
    {
        static List<Gift> gifts = new()
        {
            new Gift(){Id=1,Name="aaa",Donor="lll",Price=10,Image="111.jpg"},
            new Gift(){Id=2,Name="bbb",Donor="jjj",Price=10,Image="111.jpg"},
            new Gift(){Id=3,Name="ccc",Donor="fff",Price=10,Image="111.jpg"}
        };
        // GET: api/<GiftsController>
        [HttpGet]
        public IEnumerable<Gift> Get()
        {
            return gifts;
        }

        // GET api/<GiftsController>/5
        [HttpGet("{id}")]
        public Gift Get(int id)
        {
            return gifts.Find(g => g.Id == id);
        }

        // POST api/<GiftsController>
        [HttpPost]
        public Gift Post([FromBody] Gift gift)
        {
            gift.Id = CreateId();
            gifts.Add(gift);
            return gift;
        }

        // PUT api/<GiftsController>/5
        [HttpPut("{id}")]
        public Gift Put(int id,[FromBody] Gift gift)
        {
            
            int ind= gifts.FindIndex(g => g.Id == id);
            //להוסיף בדיקה אם אין כזה אינדקס
            gift.Id = id;
            gifts[ind]= gift;
            return gift;
        }

        // DELETE api/<GiftsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Gift g = gifts.Find(g => g.Id == id);
            gifts.Remove(g);
        }
        protected int CreateId()
        {
            return gifts.Count > 0 ? gifts[gifts.Count - 1].Id + 1 : 1;
        }
    }
}
