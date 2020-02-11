using BethanysPieShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Blazor.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
