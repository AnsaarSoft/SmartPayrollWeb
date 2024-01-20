namespace Server.Repository.Interface
{
    public interface IMstOvertime
    {
        Task<MstOvertime> GetOvertime(int id);
        Task<List<MstOvertime>> GetOvertimeList();
        Task<bool> AddOvertime(MstOvertime oRecord);
        Task<bool> UpdateOvertime(MstOvertime oRecord);
        Task<bool> DeleteOvertime(int id);
    }
}
