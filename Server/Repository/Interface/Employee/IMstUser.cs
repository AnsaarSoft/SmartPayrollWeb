﻿namespace Server.Repository.Interface.Employee
{
    public interface IMstUser
    {
        Task<MstUser?> GetUser(int id);
        Task<MstUser?> GetUser(string usercode);
        Task<List<MstUser>> GetUserList();
        Task<bool> AddUser(MstUser oRecord);
        Task<bool> UpdateUser(MstUser oRecord);
        Task<bool> DeleteUser(int id);

    }
}
