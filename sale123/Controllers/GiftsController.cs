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
            new Gift(){Id=1,Name="Shnat Limudim",Donor="Mby",Price=40,Image="111.jpg",UsersList=new List<User>(),Winner=null},
            new Gift(){Id=2,Name="Pamotim",Donor="Mitzhalot",Price=10,Image="111.jpg",UsersList=new List<User>(),Winner=null},
            new Gift(){Id=3,Name="Event",Donor="Shira Chadasha",Price=20,Image="111.jpg",UsersList=new List<User>(),Winner=null},
            new Gift(){Id=4,Name="Camera",Donor="Refaeli",Price=10,Image="111.jpg",UsersList=new List<User>(),Winner=null},
            new Gift(){Id=5,Name="Smash Cake",Donor="Yeudit Avramovsky",Price=10,Image="111.jpg",UsersList=new List<User>(),Winner=null},
            new Gift(){Id=6,Name="Wigs",Donor="Chaya Shteinberger",Price=10,Image="111.jpg",UsersList=new List<User>(),Winner=null},
            new Gift(){Id=7,Name="Manui Ktifa",Donor="Yated",Price=10,Image="111.jpg",UsersList=new List<User>(),Winner=null},
            new Gift(){Id=8,Name="Event2",Donor="Shira Chadasha",Price=10,Image="111.jpg",UsersList=new List<User>(),Winner=null},
            new Gift(){Id=9,Name="Event3",Donor="Shira Chadasha",Price=10,Image="111.jpg",UsersList=new List<User>(),Winner=null},
            new Gift(){Id=10,Name="Event4",Donor="Shira Chadasha",Price=10,Image="111.jpg",UsersList=new List<User>(),Winner=null}
        };

        

        // GET: api/<GiftsController>
        [HttpGet]
        public List<Gift> Get()
        {
            return gifts;
        }

        [HttpGet]
        [Route("random")]
        public List<Gift> GetWithWinner()
        {
            Random random = new();
            for (int i = 0; i < gifts.Count; i++)
            {
                if (gifts[i].UsersList != null)
                {
                    int len = gifts[i].UsersList.Count;
                    if (len > 0)
                    {
                        int rnd = random.Next(0, len);
                        gifts[i].Winner = gifts[i].UsersList[rnd];
                    }
                }
            }
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
        [HttpPost]
        [Route("users")]
        public List<Gift> PostUsers([FromQuery] string username, [FromBody] List<GiftForCart> giftsToCart)
        {
            for (int i = 0; i < giftsToCart.Count; i++)
            {
                int index = gifts.FindIndex(g => g.Id == giftsToCart[i].Id);

                for (int j = 0; j < giftsToCart[i].Quantity; j++)
                {
                    UsersController usersController = new();
                    User user = usersController.Get().Find(u => u.Email == username);
                    gifts[index].UsersList.Add(user);
                    
                }
            }
            return gifts;
        }

        // POST api/<GiftsController>
        [HttpPost]
        public Gift Post([FromBody] Gift gift)
        {
            gift.Id = CreateId();
            gift.UsersList = new List<User>();
            gift.Winner = null;
            gifts.Add(gift);
            return gift;
        }

        // PUT api/<GiftsController>/5
        [HttpPut("{id}")]
        public ActionResult<Gift> Put(int id,[FromBody] Gift gift)
        {
            gift.UsersList = new List<User>();
            gift.Winner = null;
            int ind= gifts.FindIndex(g => g.Id == id);
            if(ind == -1)
               return NoContent();
            else
            {
                gift.Id = id;
                gifts[ind] = gift;
                return Ok(gift);
            }
            
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
