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
using Windows.Storage;





// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace speedmath
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public class Game
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Game1
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Game2
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Game3
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Game4
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Game5
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Game6
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Game7
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Game8
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Game9
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal1
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal2
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal3
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal4
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal5
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal6
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal7
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal8
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class Gagal9
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
    }
    public class tbrank
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nilai { get; set; }
        public string nama { get; set; }
    }
    public sealed partial class MainPage : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;
        public int OrigTime { get; private set; }

        public MainPage()
        {
            this.InitializeComponent(); 
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "sqlite.db");
            conn = new SQLite.Net.SQLiteConnection(new
            SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<tbrank>();
            conn.CreateTable<Game>();
            conn.CreateTable<Game1>();
            conn.CreateTable<Game2>();
            conn.CreateTable<Game3>();
            conn.CreateTable<Game4>();
            conn.CreateTable<Game5>();
            conn.CreateTable<Game6>();
            conn.CreateTable<Game7>();
            conn.CreateTable<Game8>();
            conn.CreateTable<Game9>();
            conn.CreateTable<Gagal>();
            conn.CreateTable<Gagal1>();
            conn.CreateTable<Gagal2>();
            conn.CreateTable<Gagal3>();
            conn.CreateTable<Gagal4>();
            conn.CreateTable<Gagal5>();
            conn.CreateTable<Gagal6>();
            conn.CreateTable<Gagal7>();
            conn.CreateTable<Gagal8>();
            conn.CreateTable<Gagal9>();
           

        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Frame.Navigate(typeof(game));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(rank));
           
        }

        private void btnsign_Click(object sender, RoutedEventArgs e)
        {          
            
        }
       

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

    }
   
}

  
