﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromoDiscount
{
    class PromoController
    {
        private List<Promo> promos;

        public PromoController()
        {
            promos = new List<Promo>();
        }

        public void addPromo(Promo item)
        {
            this.promos.Add(item);
        }

        public List<Promo> getPromos()
        {
            return this.promos;
        }
    }
}
