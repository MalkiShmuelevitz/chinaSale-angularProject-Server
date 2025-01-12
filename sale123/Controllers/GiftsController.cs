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
            new Gift(){Id=1,Name="Shnat Limudim",Donor="Mby",Price=40,Image="111.jpg"},
            new Gift(){Id=2,Name="Pamotim",Donor="Mitzhalot",Price=10,Image="111.jpg"},
            new Gift(){Id=3,Name="Event",Donor="Shira Chadasha",Price=20,Image="111.jpg"},
            new Gift(){Id=4,Name="Camera",Donor="Refaeli",Price=10,Image="111.jpg"},
            new Gift(){Id=5,Name="Smash Cake",Donor="Yeudit Avramovsky",Price=10,Image="111.jpg"},
            new Gift(){Id=6,Name="Wigs",Donor="Chaya Shteinberger",Price=10,Image="111.jpg"},
            new Gift(){Id=7,Name="Manui Ktifa",Donor="Yated",Price=10,Image="111.jpg"},
            new Gift(){Id=8,Name="Event2",Donor="Shira Chadasha",Price=10,Image="111.jpg"},
            new Gift(){Id=9,Name="Event3",Donor="Shira Chadasha",Price=10,Image="111.jpg"},
            new Gift(){Id=10,Name="Event4",Donor="Shira Chadasha",Price=10,Image="111.jpg"}
        };
        // GET: api/<GiftsController>
        [HttpGet]
        public List<Gift> Get()
        {
            return gifts;
        }
        //public List<Gift> GetGiftsList()
        //{
        //    return gifts;
        //}
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
