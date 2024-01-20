namespace Server.Repository.Interface
{
    public interface IMstAdvance
    {
        Task<MstAdvance> GetAdvance(int id);
        Task<List<MstAdvance>> GetAdvanceList();
        Task<bool> AddAdvance(MstAdvance oRecord);
        Task<bool> UpdateAdvance(MstAdvance oRecord);
        Task<bool> DeleteAdvance(int id);
    }
}
