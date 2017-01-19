using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SQLite.Net.Attributes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace speedmath
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class selesai : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;

        public selesai()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "sqlite.db");
            conn = new SQLite.Net.SQLiteConnection(new
            SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            
            conn.Table<tbrank>();
            conn.Table<Game>();
            conn.Table<Game1>();
            conn.Table<Game2>();
            conn.Table<Game3>();
            conn.Table<Game4>();
            conn.Table<Game5>();
            conn.Table<Game6>();
            conn.Table<Game7>();
            conn.Table<Game8>();
            conn.Table<Game9>();
            conn.Table<Gagal>();
            conn.Table<Gagal1>();
            conn.Table<Gagal2>();
            conn.Table<Gagal3>();
            conn.Table<Gagal4>();
            conn.Table<Gagal5>();
            conn.Table<Gagal6>();
            conn.Table<Gagal7>();
            conn.Table<Gagal8>();
            conn.Table<Gagal9>();
        }
        DispatcherTimer dispatcherTimer;
        DateTimeOffset startTime;
        DateTimeOffset lastTime;
        DateTimeOffset stopTime;
        int timesTicked = 1;
        int timesToTick = 10;
        int OrigTime = 1;


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<Game>();            
            var query1 = conn.Table<Game1>();
            var query2 = conn.Table<Game2>();
            var query3 = conn.Table<Game3>();
            var query4 = conn.Table<Game4>();
            var query5 = conn.Table<Game5>();
            var query6 = conn.Table<Game6>();
            var query7 = conn.Table<Game7>();
            var query8 = conn.Table<Game8>();
            var query9 = conn.Table<Game9>();
            var query10 = conn.Table<Gagal>();
            var query11 = conn.Table<Gagal1>();
            var query12 = conn.Table<Gagal2>();
            var query13 = conn.Table<Gagal3>();
            var query14 = conn.Table<Gagal4>();
            var query15 = conn.Table<Gagal5>();
            var query16 = conn.Table<Gagal6>();
            var query17 = conn.Table<Gagal7>();
            var query18 = conn.Table<Gagal8>();
            var query19 = conn.Table<Gagal9>();
            var ranking = conn.Table<tbrank>();


            string nilai = "";
            string nilai1 = "";
            string nilai2 = "";
            string nilai3 = "";
            string nilai4 = "";
            string nilai5 = "";
            string nilai6 = "";
            string nilai7 = "";
            string nilai8 = "";
            string nilai9 = "";
            string nilai10 = "";
            string nilai11 = "";
            string nilai12 = "";
            string nilai13 = "";
            string nilai14 = "";
            string nilai15 = "";
            string nilai16 = "";
            string nilai17 = "";
            string nilai18 = "";
            string nilai19 = "";
              
           
            foreach (var message in query)
            { nilai =  message.nilai; }
            foreach (var message in query1)
            { nilai1 =  message.nilai; }
            foreach (var message in query2)
            { nilai2 =  message.nilai; }
            foreach (var message in query3)
            { nilai3 =  message.nilai; }
            foreach (var message in query4)
            { nilai4 =  message.nilai; }
            foreach (var message in query5)
            { nilai5 = message.nilai; }
            foreach (var message in query6)
            { nilai6 =  message.nilai; }
            foreach (var message in query7)
            { nilai7 =  message.nilai; }
            foreach (var message in query8)
            { nilai8 = message.nilai; }
            foreach (var message in query9)
            { nilai9 = message.nilai; }
            foreach (var message in query10)
            { nilai10 =  message.nilai; }
            foreach (var message in query11)
            { nilai11 =  message.nilai; }
            foreach (var message in query12)
            { nilai12 =  message.nilai; }
            foreach (var message in query13)
            { nilai13 = message.nilai; }
            foreach (var message in query14)
            { nilai14 =  message.nilai; }
            foreach (var message in query15)
            { nilai15 =  message.nilai; }
            foreach (var message in query16)
            { nilai16 =  message.nilai; }
            foreach (var message in query17)
            { nilai17 =  message.nilai; }
            foreach (var message in query18)
            { nilai18 =  message.nilai; }
            foreach (var message in query19)
            { nilai19 =  message.nilai; }           

            int dpt = int.Parse(nilai);
            int dpt1 = int.Parse(nilai1);
            int dpt2 = int.Parse(nilai2);
            int dpt3 = int.Parse(nilai3);
            int dpt4 = int.Parse(nilai4);
            int dpt5 = int.Parse(nilai5);
            int dpt6 = int.Parse(nilai6);
            int dpt7 = int.Parse(nilai7);
            int dpt8= int.Parse(nilai8);
            int dpt9 = int.Parse(nilai9);              
            int ami = dpt + dpt1 +dpt2 + dpt3 + dpt4 + dpt5 + dpt6 + dpt7 + dpt8 + dpt9 ;           
            txt_jumlah.Text = "jumlah = " + ami;

            var s = conn.Insert(new tbrank() //input ke database
            { nilai = ami.ToString(), nama = txt_nama.Text });

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            conn.DropTable<Game>();
            conn.DropTable<Game1>();
            conn.DropTable<Game2>();
            conn.DropTable<Game3>();
            conn.DropTable<Game4>();
            conn.DropTable<Game5>();
            conn.DropTable<Game6>();
            conn.DropTable<Game7>();
            conn.DropTable<Game8>();
            conn.DropTable<Game9>();

            conn.DropTable<Gagal>();
            conn.DropTable<Gagal1>();
            conn.DropTable<Gagal2>();
            conn.DropTable<Gagal3>();
            conn.DropTable<Gagal4>();
            conn.DropTable<Gagal5>();
            conn.DropTable<Gagal6>();
            conn.DropTable<Gagal7>();
            conn.DropTable<Gagal8>();
            conn.DropTable<Gagal9>();

            Frame.Navigate(typeof(rank));
        }
    }
}
