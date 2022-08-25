using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask.Data
{
    /// <summary>
    /// Endpoints related to device management
    /// </summary>
    public class device
    {
        /// <summary>
        /// Device ID
        /// </summary>
        [Key]
        [Required]
        public int device_id { get; set; }

        /// <summary>
        /// DeviceType
        /// </summary>
        [Required]
        [SwaggerIgnoreProperty]
        public string device_type { get; set; } = "unset";

        /// <summary>
        /// ActivationCode
        /// </summary>
        [MaxLength(16)]
        [Required]
        public string activation_code { get; set; } = string.Empty;

        /// <summary>
        /// Accept
        /// </summary>

        [Required]
        [SwaggerIgnoreProperty]
        public string accept { get; set; } = string.Empty;

        /// <summary>
        /// appVersion
        /// </summary>

        [Required]
        [SwaggerIgnoreProperty]
        public string appversion { get; set; } = string.Empty;
    }
}
