using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace FHCollection.ApiCore.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
