namespace WebOrigoTask
{
    public sealed class DeviceOwnerDetails
    {
        /// <summary>
        /// Owner name
        /// </summary>
        public string billing_name { get; set; } = string.Empty;

        /// <summary>
        /// Address country
        /// </summary>
        public string adress_country { get; set; } = string.Empty;

        /// <summary>
        /// ZIP
        /// </summary>
        public string address_zip { get; set; } = string.Empty;

        /// <summary>
        /// City
        /// </summary>
        public string address_city { get; set; } = string.Empty;

        /// <summary>
        /// Address street
        /// </summary>
        public string address_street { get; set; } = string.Empty;

        /// <summary>
        /// VAT number
        /// </summary>
        public string vat_number { get; set; } = string.Empty;
    }
}
