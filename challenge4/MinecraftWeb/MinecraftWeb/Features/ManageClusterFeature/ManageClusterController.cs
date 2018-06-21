using Microsoft.AspNetCore.Mvc;
using MinecraftWeb.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace MinecraftWeb.Features.ManageClusterFeature
{
    [Route("api/[controller]")]
    public class ManageClusterController : ControllerBase
    {
        private readonly MineKubeApiClient _kubeClient;

        public ManageClusterController(MineKubeApiClient client)
        {
            _kubeClient = client;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default(CancellationToken))
        {
            return Ok(await _kubeClient.GetServicesAync());
        }
    }
}
