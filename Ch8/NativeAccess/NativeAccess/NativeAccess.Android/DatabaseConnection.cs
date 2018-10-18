using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NativeAccess;
using Xamarin.Forms;
using SQLite;
using System.IO;
using NativeAccess.Droid;

[assembly: Dependency(typeof(DatabaseConnection))]
namespace NativeAccess.Droid
{
    public class DatabaseConnection: IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            string dbName = "MyDatabase.db3";
            string path = Path.Combine(System.Environment.
              GetFolderPath(System.Environment.
              SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }


    }
}