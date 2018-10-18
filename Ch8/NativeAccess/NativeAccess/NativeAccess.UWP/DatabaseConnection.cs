using NativeAccess.UWP;
using SQLite;
using System.IO;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection))]
namespace NativeAccess.UWP
{
    public class DatabaseConnection: IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            {
                string dbName = "MyDatabase.db3";
                string path = Path.Combine(ApplicationData.
                  Current.LocalFolder.Path, dbName);
                return new SQLiteConnection(path);
            }
        }

    }
}
