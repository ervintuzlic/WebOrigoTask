namespace WebOrigoTask
{
    public class DeviceInfoResponse
    {
        public string deviceId { get; set; }

        public string deviceType { get; set; }

        public string deviceOwner { get; set; }

        public DeviceInfoResponse deviceOwnerDetails { get; set; }

        public string dateOfRegistration { get; set; }

        public LeasingPeriodsComputed leasingPeriodsComputed { get; set; }

        public LeasingPeriods leasingPeriods { get; set; }

        public string timestamp { get; set; }
    }
}
