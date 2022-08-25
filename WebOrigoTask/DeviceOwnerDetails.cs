using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public sealed class DeviceOwnerDetails
    {
        /// <summary>
        /// Owner name
        /// </summary>
        /// <example>WebOrigo Magyarország Zrt.</example>
        [Key]
        public string billing_name { get; set; } = string.Empty;

        /// <summary>
        /// Address country
        /// </summary>
        /// <example>348</example>
        public string adress_country { get; set; } = string.Empty;

        /// <summary>
        /// ZIP
        /// </summary>
        /// <example>1027</example>
        public string address_zip { get; set; } = string.Empty;

        /// <summary>
        /// City
        /// </summary>
        /// <example>Budapest</example>
        public string address_city { get; set; } = string.Empty;

        /// <summary>
        /// Address street
        /// </summary>
        /// <example>Bem József utca 9. fszt.</example>
        public string address_street { get; set; } = string.Empty;

        /// <summary>
        /// VAT number
        /// </summary>
        /// <example>28767116-2-41</example>
        public string vat_number { get; set; } = string.Empty;
    }
}
