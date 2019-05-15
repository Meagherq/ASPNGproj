using System;
using System.Threading.Tasks;
using MyProject.Test.Dto;
using MyProject.Users.Dto;

namespace MyProject.Test
{
    public class TestAppService : MyProjectAppServiceBase, ITestAppService
    {
        public async Task<GetTestInfoOutput> GetCurrentTestInfo()
        {
            var output = new GetTestInfoOutput
            {
                Test = new TestInfoDto
                {
                    TestString = "thisisatest",
                    CurrentTime = DateTime.Now
                }

            };
            output.User = ObjectMapper.Map<UserDto>(await GetCurrentUserAsync());

            return output;

        }
    }
}