using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sale123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftsWithUsersController : ControllerBase
    {
       public static List<GiftWithUser> giftsWithUsers=new();
       //static bool flag = false;
       //public GiftsWithUsersController()
       // {
       //     GiftsController g1 = new();
       //     //var method = HttpContext?.Request?.Method;
       //     //if (method == "GET")
       //     //{

       //     //}
       //     List<Gift> newgifts = g1.Get();
       //     for (int i = 0; i < newgifts.Count; i++)
       //     {
       //         giftsWithUsers.Add(
       //         new GiftWithUser()
       //         {
       //             Id = newgifts[i].Id,
       //             Name = newgifts[i].Name,
       //             Donor = newgifts[i].Donor,
       //             Price = newgifts[i].Price,
       //             Image = newgifts[i].Image,
       //             UsersList = new List<User>(),
       //             Winner = new User()
       //         });
       //     }
       // }
        //[HttpGet]
        //public List<GiftWithUser> GetAll()
        //{ 
        //    return giftsWithUsers;
        //}

            // GET: api/<GiftsWithUsersController>
        //[HttpGet]
        //[Route("random")]
        //public List<GiftWithUser> Get()
        //{
        //    Random random=new();
        //    for (int i = 0; i < giftsWithUsers.Count; i++)
        //    {
        //        int len = giftsWithUsers[i].UsersList.Count;
        //        if (len>0)
        //        {
        //            int rnd = random.Next(0, len);
        //            giftsWithUsers[i].Winner = giftsWithUsers[i].UsersList[rnd];
        //        }
        //    }
        //    return giftsWithUsers;
        //}

        // GET api/<GiftsWithUsersController>/5
        //[HttpGet("{id}")]
        //public Gift Get(int id)
        //{
        //    return gifts.Find(g => g.Id == id);
        //}

        // POST api/<GiftsWithUsersController>
        //[HttpPost]
        //public List<GiftWithUser> Post([FromQuery] string username,[FromBody] List<GiftForCart> gifts)
        //{
        //    /////////////////////////////
        //    ///check if user found in the list
        //    ///.///////////////////////////////
        //    for (int i = 0; i < gifts.Count; i++)
        //    {
        //        int index = giftsWithUsers.FindIndex(g => g.Id == gifts[i].Id);

        //        for (int j = 0; j < gifts[i].Quantity; j++)
        //        {
        //            UsersController usersController = new();
        //            //if not found
        //            User user = usersController.Get().Find(u => u.Email == username);
        //            giftsWithUsers[index].UsersList.Add(user);
        //        }
        //    }
        //    return giftsWithUsers;
        //}

        //// PUT api/<GiftsWithUsersController>/5
        //[HttpPut("{id}")]
        //public Gift Put(int id, [FromBody] Gift gift)
        //{

        //    int ind = gifts.FindIndex(g => g.Id == id);
        //    להוסיף בדיקה אם אין כזה אינדקס
        //    gift.Id = id;
        //    gifts[ind] = gift;
        //    return gift;
        //}

        //// DELETE api/<GiftsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    Gift g = gifts.Find(g => g.Id == id);
        //    gifts.Remove(g);
        //}
        //protected int CreateId()
        //{
        //    return gifts.Count > 0 ? gifts[gifts.Count - 1].Id + 1 : 1;
        //}
    }
}
