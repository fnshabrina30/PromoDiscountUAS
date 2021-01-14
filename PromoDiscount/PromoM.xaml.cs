using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PromoDiscount
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PromoM : Window
    {
        PromoController controller;
        OnPromoChangedListener listener;
        private object listPromo;

        public PromoM()
        {
            InitializeComponent();

            controller = new PromoController();
            listPromo.ItemsSource = controller.getPromos();

            generateContentPromo();

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public void SetOnItemSelectedListener(OnPromoChangedListener listener)
        {
            this.listener = listener;
        }

        private void generateContentPromo()
        {
            Promo promo1 = new Promo("Promo Awal tahun Diskon 25 % ", diskonInPercent: 25);
            Promo promo2 = new Promo("Promo Tebus Murah Diskon 30 % ", diskonInPercent: 30);
            Promo promo3 = new Promo("Promo Natal", diskonInPercent: 10);

            controller.addPromo(promo1);
            controller.addPromo(promo2);
            controller.addPromo(promo3);

            listPromo.Items.Refresh();
        }


        private void listPromo_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ListBox listbox = sender as ListBox;
            Promo promo = listbox.SelectedItem as Promo;

            this.listener.OnPromoSelected(promo);
        }
    }

    public interface OnPromoChangedListener
    {
        void OnPromoSelected(Promo promo);
    }
}

