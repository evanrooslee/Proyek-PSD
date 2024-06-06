using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Factories
{
    public class MsCartFactory
    {
        public static MsCart Create(int CartId, int UserID, int SupplementID, int Quantity)
        {
            MsCart newCart = new MsCart();
            newCart.CartID = CartId;
            newCart.UserID = UserID;
            newCart.SupplementID = SupplementID;
            newCart.Quantity = Quantity;
            return newCart;
        }
    }
}