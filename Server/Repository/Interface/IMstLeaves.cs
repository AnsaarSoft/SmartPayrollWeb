namespace Server.Repository.Interface
{
    public interface IMstLeaves
    {
        Task<MstLeaves> GetLeaves(int id);
        Task<List<MstLeaves>> GetLeavesList();
        Task<bool> AddLeaves(MstLeaves oRecord);
        Task<bool> UpdateLeaves(MstLeaves oRecord);
        Task<bool> DeleteLeaves(int id);
    }
}
