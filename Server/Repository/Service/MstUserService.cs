using Server.Repository.Interface;

namespace Server.Repository.Service
{
    public class MstUserService : IMstUser
    {
        public Task<bool> AddUser(MstUser oRecord)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MstUser> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MstUser>> GetUserList()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(MstUser oRecord)
        {
            throw new NotImplementedException();
        }
    }
}
