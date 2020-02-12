using BethanysPieShopHRM.Server.Blazor.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Blazor.Components
{
    public class AddEmployeeDialogBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService employeeDataService { get; set; }
        [Inject]
        public IJobCategoryDataService JobCategoryDataService { get; set; }
        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

        protected string JobCategoryId = string.Empty;

        public Employee Employee { get; set; }=new Employee()
        { CountryId = 1, JobCategoryId = 0, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };

        public bool ShowDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();
            JobCategoryId = Employee.JobCategoryId.ToString();

        }
        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        public void CloseDialog()
        {
            ShowDialog = false;
            StateHasChanged();
        }
        private void ResetDialog()
        {
            Employee=new Employee() 
            { CountryId = 1, JobCategoryId = 0, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
        }
        protected async Task HandleValidSubmit()
        {
            Employee.JobCategoryId = int.Parse(JobCategoryId);
            await employeeDataService.AddEmployee(Employee);
            await CloseEventCallback.InvokeAsync(true);
            ShowDialog = false;
            StateHasChanged();
        }

    }
}
