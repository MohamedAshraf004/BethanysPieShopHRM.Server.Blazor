using BethanysPieShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Blazor.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
