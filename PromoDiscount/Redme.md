# Promo Discount
Aplikasi ini mencakup penawaran menu yang terdapat beberapa promo diskon

# Fungsi
1. Untuk menghitung jumlah barang yang akan dipesan
2. Untuk menghitung total harga yang sudah dipakai dengan promo
3. Mengetahui diskon penawaran dari toko
4. Mengetahui apa saja item yang ditampilkan
5. Sebagai bentuk mesin kalkulator

# Cara Kerja
Diawali dengan "MainWindow"

```csharp
namespace PromoDiscount
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, OnKeranjangChangedListener, OnPembayaranChangedListener, OnPenawaranChangedListener, OnPromoChangedListener
    {
        OnPembayaranChangedListener
        OnPromoChangedListener;


        MainWindowController controller;
        Pembayaran pembayaran;
        Promo promo;

        public MainWindow()
```

Terdapat Keranjang
```csharp
 class Keranjang
    {
        List<Item> itemBelanja;
        List<Promo> itemPromo;
        int capacity = 1;
        Pembayaran pembayaran;
        OnKeranjangChangedListener callback;

        public Keranjang(Pembayaran pembayaran, OnKeranjangChangedListener callback)
        {
            this.pembayaran = pembayaran;
            this.itemBelanja = new List<Item>();
            this.itemPromo = new List<Promo>();
            this.callback = callback;
        }
```
Terdapat Item
```csharp
class Item
    {
        public string title { get; set; }
        public double price { get; set; }

        public Item(string title, double price)
        {
            this.title = title;
            this.price = price;
        }
    }
```
Terdapat Penawaran
```csharp public partial class Penawaran : Window
    {
        PenawaranController controller;
        OnPenawaranChangedListener listener;

        public Penawaran()
        {
            InitializeComponent();

            controller = new PenawaranController();
            listPenawaran.ItemsSource = controller.getItems();

            generateContentPenawaran();

        }
```
Terdapat Promo atau diskon
```csharp
class Promo
    {
        public string npromo { get; set; }
        public double diskon { get; set; }

        public double diskonInPercent { get; set; }

        public Promo(string npromo, double diskon = 0, double diskonInPercent = 0)
        {
            this.npromo = npromo;
            this.diskon = diskon;
            this.diskonInPercent = diskonInPercent;
        }
```
Ada pembayaran yang merupakan total dari menu yang dipilih oleh pembeli dan sudah ditampilkan total dari promo yang dipakai
```
class Pembayaran
    {
        private double promo = 0;
        private double balance = 0;


        private OnPembayaranChangedListener paymentCallback;

        public Pembayaran(OnPembayaranChangedListener paymentCallback)
        {
            this.paymentCallback = paymentCallback;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public double getBalance()
        {
            return this.balance;
        }

        public double getPromo()
        {
            return this.promo;
        }

        public void setPromo(double promo)
        {
            this.promo = promo;
        }

        public void updateTotal(double subtotal, double potongan)
        {

            double total = subtotal + potongan;
            this.paymentCallback.onPriceUpdated(subtotal, total, potongan);
        }
    }

    interface OnPembayaranChangedListener
    {
        void onPriceUpdated(double subtotal, double grantTotal, double potongan);
    }
```

# UAS Pemrograman Lanjut
# Fiha Nur Shabrina
19.11.2854
(S1 Informatika 04)
