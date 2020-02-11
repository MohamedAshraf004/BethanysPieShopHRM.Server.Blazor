using BethanysPieShopHRM.Server.Blazor.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Blazor.Pages
{
    public class EmployeeEditBase : ComponentBase
    {
		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }

		[Inject]
		public ICountryDataService CountryDataService { get; set; }
		[Inject]
		public IJobCategoryDataService JobCategoryDataService { get; set; }
		protected override async Task OnInitializedAsync()
		{
			Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
			Countries = (await CountryDataService.GetAllCountries()).ToList();
			JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();
			CountryId = Employee.CountryId.ToString();
			JobCategoryId = Employee.JobCategoryId.ToString();
		}


		[Parameter]
		public string EmployeeId { get; set; }
		public Employee Employee { get; set; } = new Employee();
		public List<Country> Countries { get; set; } = new List<Country>();
		public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

		protected string CountryId = string.Empty;
		protected string JobCategoryId = string.Empty;
	}
}
