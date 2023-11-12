using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    public class CartItemQtyUpdateDto
    {
        public int CartItem { get; set; }
        public int Qty { get; set; }
    }
}
