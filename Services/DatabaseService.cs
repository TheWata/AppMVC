using PCLExt.FileStorage.Folders;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMVC.Services
{
     public class DatabaseService
    {
        public SQLiteConnection GetConnection()
        {
            var diretorio = new LocalRootFolder();
            var arquivo = diretorio.CreateFile("AppDatabase", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);
            return new SQLiteConnection(arquivo.Path);
        }

    }
}
