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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace speedmath
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class rank : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;
        public rank()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "sqlite.db");
            conn = new SQLite.Net.SQLiteConnection(new
            SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.Table<tbrank>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var ranking = conn.Table<tbrank>();
            string nilai = "";
            string nama = "";

            foreach (var message in ranking)
            { nama = nama + "" + message.nama; }

            foreach (var message in ranking)
            { nilai = nilai + "" + message.nilai + "\n"; }
            txt_grid.Text = nama + "_" + nilai;

            //  tbrank rank = new tbrank();
            //     rank.Id = 1;
            //    rank.nama = "fendi";
            //  // (more property assignments here) 
            //       var i = conn.InsertOrReplace(rank);
            //     // Save a Person (from UI)
            //   if (rank.Id == 0)
            //         {
            //           // New 
            //         conn.Insert(rank);
            //   }
            //        else
            //      {
            // Update 
            //        conn.Update(rank);
        }
        // Retrieve all Persons
        //   List<rank> people = (from p in conn.Table<rank>()
        //                        select p).ToList();
        //    txt_grid.Text = people.ToString();


    
    }
}
