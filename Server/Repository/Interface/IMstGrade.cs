namespace Server.Repository.Interface
{
    public interface IMstGrade
    {
        Task<MstGrade> GetGrade(int id);
        Task<List<MstGrade>> GetGradeList();
        Task<bool> AddGrade(MstGrade oRecord);
        Task<bool> UpdateGrade(MstGrade oRecord);
        Task<bool> DeleteGrade(int id);
    }
}
