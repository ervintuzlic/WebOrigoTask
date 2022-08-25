using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using WebOrigoTask.Data;

namespace WebOrigoTask.Controllers
{

    /// <summary>
    /// Endpoints related to device management
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class leasing : ControllerBase
    {
        private readonly ILogger<leasing> _logger;

        /// <summary>
        /// Endpoints related to device management
        /// </summary>
        public leasing(ILogger<leasing> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Update device's Leasing Period
        /// </summary>
        /// <response code="201">Successful registration</response>
        /// <response code="400">Bad request</response>
        [HttpPost("/leasing/update/{id}")]
        [ProducesResponseType(typeof(List<LeasingUpdateResponse>), 200)]
        [ProducesResponseType(typeof(List<LeasingUpdateResponseError>), 400)]
        public async Task<bool> UpdateDevicesAsync([BindRequired] LeasingUpdateRequest deviceToUpdate, [BindRequired][FromRoute] string id, [BindRequired][FromHeader] string ContentType, [BindRequired][FromHeader] string XAPIKEY, [BindRequired][FromHeader] string appversion)
        {
            using (var db = new ApplicationDBContext())
            {
                try
                {
                    db.leasingUpdateRequests.Update(deviceToUpdate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }

}
