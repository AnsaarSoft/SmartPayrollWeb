namespace Server.Repository.Interface
{
    public interface IMstCity
    {
        Task<MstCity> GetCity(int id);
        Task<List<MstCity>> GetCityList();
        Task<bool> AddCity(MstCity oRecord);
        Task<bool> UpdateCity(MstCity oRecord);
        Task<bool> DeleteCity(int id);
    }
}
