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

        ///// <summary>
        ///// Register device
        ///// </summary>
        ///// <response code="201">Successful registration</response>
        ///// <response code="400">Bad request</response>
        //[HttpPost("/device/register")]
        //[SwaggerResponse(201, "Successful registration")]
        //[SwaggerResponse(400, "Bad request")]
        //public async Task<bool> CreateDeviceAsync([BindRequired][FromHeader] string ContentType, [BindRequired][FromHeader] string Accept, [BindRequired][FromHeader] string appVersion, Data.device t)
        //{
        //    using (var db = new ApplicationDBContext())
        //    {
        //        try
        //        {
        //            if (t.activation_code == String.Empty)
        //                t.device_type = "free";

        //            else 
        //                t.device_type = ContentType;

        //            t.accept = Accept;
        //            t.appversion = appVersion;

        //            await db.Tablets.AddAsync(t);

        //            return await db.SaveChangesAsync() >= 1;
        //        }
        //        catch (Exception ex)
        //        {
        //            return false;
        //        }
        //    }
        //}


        /// <summary>
        /// Register device
        /// </summary>
        /// <response code="201">Successful registration</response>
        /// <response code="400">Bad request</response>
        [HttpPost("/device/register")]
        [SwaggerResponse(201, "Successful registration")]
        [SwaggerResponse(400, "Bad request")]
        public async Task<bool> CreateDeviceAsync([BindRequired] Data.device t, [BindRequired][FromHeader] string ContentType, [BindRequired][FromHeader] string Accept, [BindRequired][FromHeader] string appVersion)
        {
            using (var db = new ApplicationDBContext())
            {
                try
                {
                    if (t.activation_code == String.Empty)
                        t.device_type = "free";

                    else
                        t.device_type = ContentType;

                    t.accept = Accept;
                    t.appversion = appVersion;

                    await db.Tablets.AddAsync(t);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        [HttpGet("/device/info/{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Data.device> GetTabletById(int id)
        {
            using (var db = new ApplicationDBContext())
            {
                try
                {
                    return await db.Tablets.FirstOrDefaultAsync(tablet => tablet.device_id == id);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        [HttpGet("/device/info/getAll")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<List<Data.device>> GetTabletsAsync()
        {
            using (var db = new ApplicationDBContext())
            {
                return await db.Tablets.ToListAsync();
            }
        }
    }
}
