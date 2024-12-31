using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sale123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        static List<Cart> carts = new()
        {
            new Cart(){
                Id=1,
                UserId=1,
                Gifts=new List<GiftForCart>()
                    {
                    new GiftForCart(){
                        Id=1,
                        Name="aaa",
                        Donor="lll",
                        Price=10,
                        Image="111.jpg",
                        Quantity=10
                    } 
                }
                },
             new Cart(){
                Id=2,
                UserId=2,
                Gifts=new List<GiftForCart>()
                    {
                    new GiftForCart(){
                        Id=1,
                        Name="bbb",
                        Donor="lll",
                        Price=10,
                        Image="111.jpg",
                        Quantity=1
                    }
                }
                }

        };
        // GET: api/<CartsController>
        //[HttpGet]
        //public List<Cart> Get()
        //{
        //    return carts;
        //}

        // GET api/<CartsController>/5
        [HttpGet("{id}")]
        public Cart Get(int userId)
        {
            Cart cart = carts.Find(x => x.UserId == userId);
            return cart;
        }

        //// POST api/<CartsController>
        [HttpPost]
        public Cart Post([FromBody] Cart cart)
        {
            cart.Id = CreateId();
            carts.Add(cart);
            return cart;
        }

        // PUT api/<CartsController>/5
        [HttpPut("{id}")]
        public void Put(int userId, [FromBody] Gift gift)
        {
            Cart cart = carts.Find(u => u.UserId == userId);
            int indOfCart = carts.FindIndex(u => u.UserId == userId);
            GiftForCart giftForCart = cart.Gifts.Find(g => g.Id == gift.Id);
            int indOfGift = cart.Gifts.FindIndex(g => g.Id == gift.Id);
            if (giftForCart != null)
            {
                giftForCart.Quantity++;
                carts[indOfCart].Gifts[indOfGift] = giftForCart;
            }
            else
            {
                cart.Gifts.Add(
                new GiftForCart()
                {
                    Id = gift.Id,
                    Name = gift.Name,
                    Price = gift.Price,
                    Image = gift.Image,
                    Donor = gift.Donor,
                    Quantity = 1
                });
                carts[indOfCart]= cart;
            }

        }

        //// DELETE api/<CartsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
        protected int CreateId()
        {
            return carts.Count > 0 ? carts[carts.Count - 1].Id + 1 : 1;
        }
    }
}
