namespace Server.Repository.Interface
{
    public interface IMstDepartment
    {
        Task<MstDepartment> GetDepartment(int id);
        Task<List<MstDepartment>> GetDepartmentList();
        Task<bool> AddDepartment(MstDepartment oRecord);
        Task<bool> UpdateDepartment(MstDepartment oRecord);
        Task<bool> DeleteDepartment(int id);
    }
}
