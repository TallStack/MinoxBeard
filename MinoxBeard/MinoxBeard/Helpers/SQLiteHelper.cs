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
            db.CreateTableAsync<RoutineModel>().Wait();
            db.CreateTableAsync<MoreInfo>().Wait();
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
        
        public Task<int> SaveItemAsync(RoutineModel obj)
        {
            if (obj.RoutineID != 0)
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
        
        public Task<int> DeleteItemAsync(RoutineModel obj)
        {
            return db.DeleteAsync(obj);
        }

        //Read All Items  
        public Task<List<UsageModel>> GetItemsAsync()
        {
            return db.Table<UsageModel>().ToListAsync();
        }
        
        public Task<List<RoutineModel>> GetRoutineItemsAsync()
        {
            return db.Table<RoutineModel>().ToListAsync();
        }


        //Read Item  
        public Task<UsageModel> GetItemAsync(int usageID)
        {
            return db.Table<UsageModel>().Where(i => i.UsageID == usageID).FirstOrDefaultAsync();
        }
        public Task<RoutineModel> GetRoutineItemAsync(int RoutineID)
        {
            return db.Table<RoutineModel>().Where(i => i.RoutineID == RoutineID).FirstOrDefaultAsync();
        }
    }
}