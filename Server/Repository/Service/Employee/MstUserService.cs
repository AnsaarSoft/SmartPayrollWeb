﻿namespace Server.Repository.Service.Employee
{
    public class MstUserService : IMstUser
    {
        private readonly AppDBContext odb;
        private readonly ILogger<MstUserService> logger;
        public MstUserService(AppDBContext context, ILogger<MstUserService> log) 
        {
            odb = context;
            logger = log;
        }

        public async Task<bool> AddUser(MstUser oRecord)
        {
            try
            {
                if(oRecord is null) { return false; } 
                odb.MstUsers.Add(oRecord);
                await odb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> UpdateUser(MstUser oRecord)
        {
            try
            {
                if (oRecord is null) { return false; }
                odb.MstUsers.Update(oRecord);
                await odb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> DeleteUser(int id)
        {
            try
            {
                if (id == 0)
                {
                    return false;
                }
                var oRecord = await (from a in odb.MstUsers
                               where a.Id == id
                               select a).FirstOrDefaultAsync();
                if (oRecord is null) { return false; }
                oRecord.flgDelete = true;
                oRecord.flgActive = false;
                await odb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<MstUser?> GetUser(int id)
        {
            MstUser? oRecord = new();
            try
            {
                if (id == 0) { return oRecord; }
                oRecord = await (from a in odb.MstUsers
                                    where a.Id == id
                                    select a).FirstOrDefaultAsync();
                
                return oRecord;
            }
            catch (Exception ex)
            {
                return oRecord;
            }
        }
        public async Task<MstUser?> GetUser(string usercode)
        {
            MstUser? oRecord = new();
            try
            {
                if (string.IsNullOrEmpty(usercode)) { return oRecord; }
                oRecord = await (from a in odb.MstUsers
                                 where a.UserCode == usercode
                                 select a).FirstOrDefaultAsync();

                return oRecord;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "getuser error on database");
                return oRecord;
            }
        }
        public async Task<List<MstUser>> GetUserList()
        {
            List<MstUser> oRecords = new();
            try
            {
                oRecords = await (from a in odb.MstUsers
                                  select a).ToListAsync();
            }
            catch (Exception ex)
            {

            }
            return oRecords;
        }

        
    }
}
