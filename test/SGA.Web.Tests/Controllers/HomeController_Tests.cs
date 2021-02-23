using System.Threading.Tasks;
using SGA.Models.TokenAuth;
using SGA.Web.Controllers;
using Shouldly;
using Xunit;

namespace SGA.Web.Tests.Controllers
{
    public class HomeController_Tests: SGAWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}