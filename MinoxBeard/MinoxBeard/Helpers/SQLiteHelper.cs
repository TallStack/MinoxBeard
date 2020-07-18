using MinoxBeard.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinoxBeard.Helpers
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<UsageModel>().Wait();
        }

        //Insert and Update new record  
        public Task<int> SaveItemAsync(UsageModel obj)
        {
            if (obj.UsageID != 0)
            {
                return db.UpdateAsync(obj);
            }
            else
            {
                return db.InsertAsync(obj);
            }
        }

        //Delete  
        public Task<int> DeleteItemAsync(UsageModel obj)
        {
            return db.DeleteAsync(obj);
        }

        //Read All Items  
        public Task<List<UsageModel>> GetItemsAsync()
        {
            return db.Table<UsageModel>().ToListAsync();
        }


        //Read Item  
        public Task<UsageModel> GetItemAsync(int usageID)
        {
            return db.Table<UsageModel>().Where(i => i.UsageID == usageID).FirstOrDefaultAsync();
        }
    }
}