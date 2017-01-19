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
    /// 
    
    public sealed partial class game2 : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;
        public game2()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "sqlite.db");
            conn = new SQLite.Net.SQLiteConnection(new
            SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.Table<Game2>();
        }
        DispatcherTimer dispatcherTimer;
        DateTimeOffset startTime;
        DateTimeOffset lastTime;
        DateTimeOffset stopTime;
        int timesTicked = 1;
        int timesToTick = 10;
        int OrigTime = 10;
        int ntime = 1;
        Random rnd = new Random(); //start soal

        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Tick += dispatcherTimer_Tick1;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        }
        void dispatcherTimer_Tick(object sender, object e)
        {
            DateTimeOffset time = DateTimeOffset.Now;
            TimeSpan span = time - lastTime;
            lastTime = time;
            OrigTime--;
            ntime++;
            Timeaja.Text = ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if (Timeaja.Text == "00")
            {
                dispatcherTimer.Stop();
                var s = conn.Insert(new Game2() //input ke database
                { nilai = Timeaja.Text });
                Frame.Navigate(typeof(gagal2));
            }
        }
        void dispatcherTimer_Tick1(object sender, object e)
        {
            DateTimeOffset time = DateTimeOffset.Now;
            TimeSpan span = time - lastTime;
            lastTime = time;

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimerSetup(); //start timer        
            int angka1 = rnd.Next(1, 10);
            int angka2 = rnd.Next(1, 20);
            int angka3 = rnd.Next(1, 9);
            int angka4 = rnd.Next(5, 9);
            int angka5 = rnd.Next(7, 11);
            int angka6 = rnd.Next(1, 5);
            textBlock.Text = angka1.ToString() + "  +  " + angka2.ToString() + "  x  " + angka3.ToString() + "  = ?";
            int benar = angka1 + angka2 * angka3;
            int salah1 = angka1 + angka2 * angka3 + angka4;
            int salah2 = angka1 + angka2 * angka3 + angka4 + angka5;
            int salah3 = angka1 + angka2 * angka3 + angka4 / angka4 * 2;
            if (angka6 == 1)
            {
                btn_a.Content = benar.ToString();
                btn_b.Content = salah1.ToString();
                btn_c.Content = salah2.ToString();
                btn_d.Content = salah3.ToString();
            }
            else if (angka6 == 2)
            {
                btn_c.Content = benar.ToString();
                btn_b.Content = salah1.ToString();
                btn_a.Content = salah2.ToString();
                btn_d.Content = salah3.ToString();
            }
            else if (angka6 == 3)
            {
                btn_d.Content = benar.ToString();
                btn_b.Content = salah1.ToString();
                btn_a.Content = salah2.ToString();
                btn_c.Content = salah3.ToString();
            }
            else if (angka6 >= 4)
            {
                btn_b.Content = benar.ToString();
                btn_c.Content = salah1.ToString();
                btn_a.Content = salah2.ToString();
                btn_d.Content = salah3.ToString();
            }
        }

        private void btn_a_Click(object sender, RoutedEventArgs e)
        {
            string ambil1 = textBlock.Text;
            string ambil2 = textBlock.Text;
            string ambil3 = textBlock.Text;
            int angka1 = int.Parse(ambil1.Substring(0, 2));
            int angka2 = int.Parse(ambil2.Substring(6, 2));
            int angka3 = int.Parse(ambil2.Substring(12, 2));
            int jumlah = angka1 + angka2 * angka3;

            if ((string)this.btn_a.Content == jumlah.ToString())
            {
                dispatcherTimer.Stop();
                var s = conn.Insert(new Game2() //input ke database
                { nilai = Timeaja.Text });
                Frame.Navigate(typeof(game3));
            }
            else
            {
                dispatcherTimer.Stop();
                var s = conn.Insert(new Game2() //input ke database
                { nilai = Timeaja.Text });
                Frame.Navigate(typeof(gagal2));
            }
        }

        private void btn_b_Click(object sender, RoutedEventArgs e)
        {
            string ambil1 = textBlock.Text;
            string ambil2 = textBlock.Text;
            string ambil3 = textBlock.Text;
            int angka1 = int.Parse(ambil1.Substring(0, 2));
            int angka2 = int.Parse(ambil2.Substring(6, 2));
            int angka3 = int.Parse(ambil2.Substring(12, 2));
            int jumlah = angka1 + angka2 * angka3;
            if ((string)this.btn_b.Content == jumlah.ToString())
            {
                dispatcherTimer.Stop();
                var s = conn.Insert(new Game2() //input ke database
                { nilai = Timeaja.Text });
                Frame.Navigate(typeof(game3));
            }
            else
            {
                dispatcherTimer.Stop();
                var s = conn.Insert(new Game2() //input ke database
                { nilai = Timeaja.Text });
                Frame.Navigate(typeof(gagal2));
            }

        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            string ambil1 = textBlock.Text;
            string ambil2 = textBlock.Text;
            string ambil3 = textBlock.Text;
            int angka1 = int.Parse(ambil1.Substring(0, 2));
            int angka2 = int.Parse(ambil2.Substring(6, 2));
            int angka3 = int.Parse(ambil2.Substring(12, 2));
            int jumlah = angka1 + angka2 * angka3;
            if ((string)this.btn_c.Content == jumlah.ToString())
            {
                dispatcherTimer.Stop();
                var s = conn.Insert(new Game2() //input ke database
                { nilai = Timeaja.Text });
                Frame.Navigate(typeof(game3));
            }
            else
            {
                dispatcherTimer.Stop();
                var s = conn.Insert(new Game2() //input ke database
                { nilai = Timeaja.Text });
                Frame.Navigate(typeof(gagal2));
            }
        }

        private void btn_d_Click(object sender, RoutedEventArgs e)
        {
            string ambil1 = textBlock.Text;
            string ambil2 = textBlock.Text;
            string ambil3 = textBlock.Text;
            int angka1 = int.Parse(ambil1.Substring(0, 2));
            int angka2 = int.Parse(ambil2.Substring(6, 2));
            int angka3 = int.Parse(ambil2.Substring(12, 2));
            int jumlah = angka1 + angka2 * angka3;
            if ((string)this.btn_d.Content == jumlah.ToString())
            {
                dispatcherTimer.Stop();
                var s = conn.Insert(new Game2() //input ke database
                { nilai = Timeaja.Text });
                Frame.Navigate(typeof(game3));
            }
            else
            {
                dispatcherTimer.Stop();
                var s = conn.Insert(new Game2() //input ke database
                { nilai = Timeaja.Text });
                Frame.Navigate(typeof(gagal2));
            }
        }
    }
}
