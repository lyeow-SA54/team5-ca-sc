﻿using System.Collections.Generic;
using System.Linq;
using team5_SC.Models;

namespace team5_SC.DataHelper
{
    public class CartQty
    {
        public static int get(Session session,User user,DBContext dbContext)
        {
            int qty = 0;


            if(session != null && user == null)
            {
                //List<Cart> userCart = dbContext.Carts.Where(x => x.User.Id == user.Id).ToList();

                //foreach (Cart cart in userCart)
                //{
                //    qty += cart.Quantity;
                //}

                //return qty;
            }

            if(session != null && user != null)
            {
                List<Cart> userCart = dbContext.Carts.Where(x => x.User.Id == user.Id).ToList();

                foreach (Cart cart in userCart)
                {
                    qty += cart.Quantity;
                }
            }

            

            return qty;
        }
    }
}