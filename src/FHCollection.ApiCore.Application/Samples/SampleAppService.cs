using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;

namespace FHCollection.ApiCore.Samples
{
    /// <summary>
    /// RemoteService可用于将实现IRemoteService接口的类标记为远程服务或禁用它
    /// </summary>
    [RemoteService(IsEnabled = false)] //or simply [RemoteService(false)]
    public class SampleAppService : ApiCoreAppService, ISampleAppService
    {
        public Task<SampleDto> GetAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }

        [Authorize]
        public Task<SampleDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }
    }
}