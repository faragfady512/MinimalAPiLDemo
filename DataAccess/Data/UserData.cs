using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DbAccess;

namespace DataAccess.Data
{

    public class UserData : IUserData
    {
        private readonly IsqlDataAcess _db;

        public UserData(IsqlDataAcess db)
        {
            _db = db;
        }

        public Task<IEnumerable<UserModel>> GetUsers() =>
           _db.LoadData<UserModel, dynamic>("dbo.spUser_getAll", new { });

        public async Task<UserModel> GetUser(int id)
        {
            var results = await _db.LoadData<UserModel, dynamic>("dbo.spUser_Get", new { Id = id });
            return results.FirstOrDefault();

        }
        
        public Task UpdatetUser( UserModel user) =>
            _db.SaveData( "dbo.spUser_Update", user);

        public Task InsertUser(UserModel user) =>
            _db.SaveData( "dbo.spUser_Insert", new { user.FirstName ,user.LastName});   


        public Task DeleteUser(int id) =>
            _db.SaveData("dbo.spUser_Delete", new { Id = id });

        public Task UpdatetUser(UserModel user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
