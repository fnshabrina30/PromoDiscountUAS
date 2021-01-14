using System;
using System.Collections.Generic;
using System.Text;

namespace PromoDiscount
{
    class MainWindowController
    {
        Keranjang keranjang;

        public MainWindowController(Keranjang keranjang)
        {
            this.keranjang = keranjang;
        }

        public void addItem(Item item)
        {
            this.keranjang.addItem(item);
        }

        public void addPromo(Promo item)
        {
            this.keranjang.addPromo(item);
        }

        public List<Item> getSelectedItems()
        {
            return this.keranjang.getItems();
        }

        public List<Promo> getSelectedPromos()
        {
            return this.keranjang.getPromos();
        }

        public void deleteSelectedItem(Item item)
        {
            this.keranjang.removeItem(item);
        }

        public void deleteSelectedPromo(Promo item)
        {
            this.keranjang.removePromo(item);
        }

    }
}