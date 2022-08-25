using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask.Data
{
    /// <summary>
    /// Endpoints related to device management
    /// </summary>
    public class DeviceRegisterRequest
    {
        /// <summary>
        /// Device ID
        /// </summary>
        /// <example>NW-H-20-0017</example>
        [Key]
        [Required]
        public string deviceId { get; set; }

        /// <summary>
        /// DeviceType
        /// </summary>
        [SwaggerIgnoreProperty]
        public string deviceType { get; set; } = "unset";

        /// <summary>
        /// ActivationCode
        /// </summary>
        /// /// <example>XB67FGC2561XDFG2</example>
        [MaxLength(16)]
        public string activationCode { get; set; } = string.Empty;

        /// <summary>
        /// Accept
        /// </summary>

        [SwaggerIgnoreProperty]
        public string accept { get; set; } = string.Empty;

        /// <summary>
        /// appVersion
        /// </summary>

        [SwaggerIgnoreProperty]
        public string appVersion { get; set; } = string.Empty;
    }
}
