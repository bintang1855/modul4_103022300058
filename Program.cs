using modul4_103022300058;

class Program {
    static void Main() {
        //Console.WriteLine("Soal 1. Daftar Produk");
        //foreach (KodeProduk.produkElektronik produk in Enum.GetValues(typeof(KodeProduk.produkElektronik)) )
        //{
        //    string kodeproduk = KodeProduk.getKodeProduk(produk);
        //    Console.WriteLine("- " + produk + ": " + kodeproduk);
        //}

        FanLaptop laptopJalan = new FanLaptop();
        laptopJalan.activateTrigger(FanLaptop.Trigger.Turbo_Shortcut);
        laptopJalan.activateTrigger(FanLaptop.Trigger.Mode_Up);

    }
}
