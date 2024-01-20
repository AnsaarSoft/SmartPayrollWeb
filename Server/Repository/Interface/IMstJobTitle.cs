namespace Server.Repository.Interface
{
    public interface IMstJobTitle
    {
        Task<MstJobTitle> GetJobTitle(int id);
        Task<List<MstJobTitle>> GetJobTitleList();
        Task<bool> AddJobTitle(MstJobTitle oRecord);
        Task<bool> UpdateJobTitle(MstJobTitle oRecord);
        Task<bool> DeleteJobTitle(int id);
    }
}
