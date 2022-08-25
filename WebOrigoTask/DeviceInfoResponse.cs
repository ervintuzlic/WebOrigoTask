using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public class DeviceInfoResponse
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
        /// <example>leasing</example>
        public string deviceType { get; set; } = string.Empty;

        /// <summary>
        /// Device Owner
        /// </summary>
        /// <example>WebOrigo Magyarország Zrt.</example>
        public string deviceOwner { get; set; } = string.Empty;

        /// <summary>
        /// Device Owner Details
        /// </summary>
        /// <example>device Owner Details</example>
        public DeviceOwnerDetails deviceOwnerDetails { get; set; }

        /// <summary>
        /// Date of registration
        /// </summary>
        /// <example>2021-11-04</example>
        public string dateOfRegistration { get; set; } = string.Empty;

        /// <summary>
        /// Leasing period computed
        /// </summary>
        /// <example>leasing Periods Computed</example>
        public LeasingPeriodsComputed leasingPeriodsComputed { get; set; }

        /// <summary>
        /// Leasing Periods
        /// </summary>
        /// <example>leasing</example>
        public LeasingPeriods leasingPeriods { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        /// <example>2021-07-01 00:00:00</example>
        public string timestamp { get; set; } = string.Empty;
    }
}
