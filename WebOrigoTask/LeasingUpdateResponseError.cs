using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public class LeasingUpdateResponseError
    {
        /// <example>ERROR_API_KEY</example>
        [Key]
        public string title { get; set; } = "Leasing construction update failed";
        /// <example>Api key header is missing</example>
        public string description { get; set; } = "Leasing construction update failed";
    }
}
