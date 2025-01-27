using Microsoft.AspNetCore.Mvc;
using System.Drawing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sale123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        static List<Donor> donors = new List<Donor>()
        {
            new Donor(){Id=1, fullName="Horovitz Cars",Adress="Shaarei Hair 54",Phone="02-6456374",Email="hCars@gmail.com"},
            new Donor(){Id=2, fullName="Orchid",Adress="Yrmiauh 21",Phone="077-8767645",Email="orchid.kitchens@gmail.com"},
            new Donor(){Id=3, fullName="Shulchan Melachim",Adress="Yohel 10",Phone="055-6745365",Email="Shulchanot@gmail.com"},
            new Donor(){Id=4, fullName="Shpitzer",Adress="Grosberg 10",Phone="02-6635463",Email="sh.sh@gmail.com"},
            new Donor(){Id=5, fullName="Noam",Adress="Talpiot 24",Phone="02-5654356",Email="Noam@noam.co.il"},
            new Donor(){Id=6, fullName="NespresoCompany",Adress="Naariah 23",Phone="03-6275342",Email="Nespreso1@nes.co.il"},
            new Donor(){Id=7, fullName="Yated",Adress="hdfg",Phone="30",Email="5342@q"},
        };
        // GET: api/<DonorsController>
        [HttpGet]
        public IEnumerable<Donor> Get()
        {
            return donors;
        }

        // GET api/<DonorsController>/5
        [HttpGet("{id}")]
        public Donor Get(int id)
        {
            return donors.Find(d => d.Id == id);
        }

        // POST api/<DonorsController>
        [HttpPost]
        public Donor Post([FromBody] Donor donor)
        {
            donor.Id = CreateId();
            donors.Add(donor);
            return donor;
        }

        // PUT api/<DonorsController>/5
        [HttpPut("{id}")]
        public Donor Put(int id, [FromBody] Donor donor)
        {
            int ind = donors.FindIndex(d => d.Id == id);
            donor.Id = id;
            donors[ind] = donor;
            return donor;
        }

        // DELETE api/<DonorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            donors.Remove(donors.Find(d => d.Id == id));
        }

        protected int CreateId()
        {
            return donors != null ? donors[donors.Count - 1].Id + 1 : 1;
        }
    }
}
