using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SQLite;
using System.IO;
using NativeAccess;
using NativeAccess.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseConnection))]
namespace NativeAccess.iOS
{
    public class DatabaseConnection: IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            string dbName = "MyDatabase.db3";
            string personalFolder =
              System.Environment.
              GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder =
              Path.Combine(personalFolder, "..", "Library");
            string path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }

    }
}