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
            new User(){Id=1, FullName="aaa",Password="aaa",Adress="trye",Phone="10",Email="1@1.1",CreditCard="234424234",Role="Admin"},
            new User(){Id=2, FullName="bbb",Password="ccc",Adress="yrte",Phone="10",Email="2@2.2",CreditCard="346334454",Role="User"},
            new User(){Id=3, FullName="ccc",Password="ddd",Adress="fhgd",Phone="20",Email="3@3.3",CreditCard="423434343",Role="User"},
            new User(){Id=4, FullName="ddd",Password="eee",Adress="hdfg",Phone="30",Email="4@4.4",CreditCard="234423434",Role="User"},
        };
        // GET: api/<UsersController>
        [HttpGet]
        public List<User> Get()
        {
            return Users;
        }

        //// GET api/<UsersController>/5
        //[HttpGet("{id}")]
        //public User Get(int id)
        //{
        //    return Users.Find(d => d.Id == id);
        //}
        // POST api/<UsersController>
        [HttpPost]
        [Route("login")]
        public ActionResult<User> Post([FromBody] UserLogin userl)
        {
            User user = Users.Find(u => u.Email == userl.UserName && u.Password == userl.Password);
            if(user!=null)
                return Ok(user);
            return NoContent();
        }
        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            user.Id = CreateId();
            user.Role = "User";
            if (Users.FindIndex((u) => u.Email==user.Email) > -1)
                //check with action result to return
                return NoContent();
            else
                Users.Add(user);
                return Ok(user);
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
