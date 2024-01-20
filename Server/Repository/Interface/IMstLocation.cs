namespace Server.Repository.Interface
{
    public interface IMstLocation
    {
        Task<MstLocation> GetLocation(int id);
        Task<List<MstLocation>> GetLocationList();
        Task<bool> AddLocation(MstLocation oRecord);
        Task<bool> UpdateLocation(MstLocation oRecord);
        Task<bool> DeleteLocation(int id);
    }
}
