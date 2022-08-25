using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public class DeviceInfoResponse
    {
        /// <summary>
        /// Device ID
        /// </summary>
        [Key]
        [Required]
        public string deviceId { get; set; }

        /// <summary>
        /// DeviceType
        /// </summary>
        [SwaggerIgnoreProperty]
        public string deviceType { get; set; }

        /// <summary>
        /// Device Owner
        /// </summary>
        public string deviceOwner { get; set; }

        /// <summary>
        /// Device Owner Details
        /// </summary>
        [SwaggerIgnoreProperty]
        public DeviceInfoResponse deviceOwnerDetails { get; set; }

        /// <summary>
        /// Date of registration
        /// </summary>
        public string dateOfRegistration { get; set; }

        /// <summary>
        /// Leasing period computed
        /// </summary>
        public LeasingPeriodsComputed leasingPeriodsComputed { get; set; }

        /// <summary>
        /// Leasing Periods
        /// </summary>
        public LeasingPeriods leasingPeriods { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        public string timestamp { get; set; }
    }
}
