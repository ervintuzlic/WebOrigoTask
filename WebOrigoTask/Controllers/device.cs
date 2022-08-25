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
    public class device : ControllerBase
    {
        private readonly ILogger<device> _logger;

        /// <summary>
        /// Endpoints related to device management
        /// </summary>
        public device(ILogger<device> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Register device
        /// </summary>
        /// <response code="201">Successful registration</response>
        /// <response code="400">Bad request</response>
        [HttpPost("/device/register")]
        [ProducesResponseType(typeof(List<Data.DeviceRegisterRequest>), 201)]
        [ProducesResponseType(typeof(List<ErrorResponse>), 400)]
        public async Task<bool> CreateDeviceAsync([BindRequired] Data.DeviceRegisterRequest t, [BindRequired][FromHeader] string ContentType, [BindRequired][FromHeader] string Accept, [BindRequired][FromHeader] string appVersion)
        {
            using (var db = new ApplicationDBContext())
            {
                try
                {
                    if (t.activationCode == String.Empty)
                        t.deviceType = "free";

                    else
                        t.deviceType = ContentType;

                    t.accept = Accept;
                    t.appVersion = appVersion;

                    await db.Devices.AddAsync(t);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }


        /// <summary>
        /// Retrieve device information
        /// </summary>
        /// <response code="200">Device information</response>
        /// <response code="400">Bad request</response>
        [HttpGet("/device/info/{id}")]
        [ProducesResponseType(typeof(List<DeviceInfoResponse>), 200)]
        [ProducesResponseType(typeof(List<ErrorResponse>), 400)]
        public async Task<Data.DeviceRegisterRequest> GetTabletById([BindRequired] string id, [BindRequired][FromHeader] string ContentType, [BindRequired][FromHeader] string Accept, [BindRequired][FromHeader] string XAPIKEY, [BindRequired][FromHeader] string appVersion)
        {
            using (var db = new ApplicationDBContext())
            {
                try
                {
                    return await db.Devices.FirstOrDefaultAsync(tablet => tablet.deviceId == id);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        //[HttpGet("/device/info/getAll")]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<List<Data.DeviceRegisterRequest>> GetTabletsAsync()
        //{
        //    using (var db = new ApplicationDBContext())
        //    {
        //        return await db.Devices.ToListAsync();
        //    }
        //}
    }
}
