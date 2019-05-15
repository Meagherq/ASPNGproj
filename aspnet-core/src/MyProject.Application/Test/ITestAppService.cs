using System.Threading.Tasks;
using Abp.Application.Services;

namespace MyProject.Test.Dto
{
    public interface ITestAppService : IApplicationService
    {
        Task<GetTestInfoOutput> GetCurrentTestInfo();
    }
}
