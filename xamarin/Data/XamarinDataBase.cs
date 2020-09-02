using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using xamarin.Models;
using System.Threading.Tasks;

namespace xamarin.Data
{
    public class XamarinDataBase
    {
        readonly SQLiteAsyncConnection _database;

        public XamarinDataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SQLXamarin>().Wait();
        }

        public Task<List<SQLXamarin>> GetxamarinAsync()
        {
            return _database.Table<SQLXamarin>().ToListAsync();
        }

        public Task<SQLXamarin> GetxamarinAsync(int id)
        {
            return _database.Table<SQLXamarin>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SavexamarinAsync(SQLXamarin note)
        {
            if(note.ID != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }
        public Task<int> DeletexamarinAsync(SQLXamarin note)
        {
            return _database.DeleteAsync(note);
        }
    }
}
