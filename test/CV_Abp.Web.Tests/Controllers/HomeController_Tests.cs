using System.Threading.Tasks;
using CV_Abp.Models.TokenAuth;
using CV_Abp.Web.Controllers;
using Shouldly;
using Xunit;

namespace CV_Abp.Web.Tests.Controllers
{
    public class HomeController_Tests: CV_AbpWebTestBase
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