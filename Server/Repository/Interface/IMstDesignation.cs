﻿namespace Server.Repository.Interface
{
    public interface IMstDesignation
    {
        Task<MstDesignation> GetDesignation(int id);
        Task<List<MstDesignation>> GetDesignationList();
        Task<bool> AddDesignation(MstDesignation oRecord);
        Task<bool> UpdateDesignation(MstDesignation oRecord);
        Task<bool> DeleteDesignation(int id);
    }
}
