using Microsoft.AspNetCore.Mvc;
using System.Drawing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sale123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        static List<User> Users = new List<User>()
        {
            new User(){Id=1, fullName="aaa",Adress="trye",Phone="10",Email="112"},
            new User(){Id=2, fullName="bbb",Adress="yrte",Phone="10",Email="5324"},
            new User(){Id=3, fullName="ccc",Adress="fhgd",Phone="20",Email="2354"},
            new User(){Id=4, fullName="ddd",Adress="hdfg",Phone="30",Email="5342"},
        };
        // GET: api/<UsersController>
        //[HttpGet]
        //public IEnumerable<User> Get()
        //{
        //    return Users;
        //}

        //// GET api/<UsersController>/5
        //[HttpGet("{id}")]
        //public User Get(int id)
        //{
        //    return Users.Find(d => d.Id == id);
        //}

        // POST api/<UsersController>
        [HttpPost]
        public User Post([FromBody] User user)
        {
            user.Id = CreateId();
            Users.Add(user);
            return user;
        }

        // PUT api/<UsersController>/5
        //[HttpPut("{id}")]
        //public User Put(int id, [FromBody] User User)
        //{
        //    int ind = Users.FindIndex(d => d.Id == id);
        //    User.Id = id;
        //    Users[ind] = User;
        //    return User;
        //}

        //// DELETE api/<UsersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    Users.Remove(Users.Find(d => d.Id == id));
        //}

        protected int CreateId()
        {
            return Users != null ? Users[Users.Count - 1].Id + 1 : 1;
        }
    }
}
