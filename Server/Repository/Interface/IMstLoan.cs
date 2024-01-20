namespace Server.Repository.Interface
{
    public interface IMstLoan
    {
        Task<MstLoan> GetLoan(int id);
        Task<List<MstLoan>> GetLoanList();
        Task<bool> AddLoan(MstLoan oRecord);
        Task<bool> UpdateLoan(MstLoan oRecord);
        Task<bool> DeleteLoan(int id);
    }
}
