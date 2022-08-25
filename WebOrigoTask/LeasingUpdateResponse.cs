using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public class LeasingUpdateResponse
    {
        ///<example>SUCCESS</example>
        [Key]
        public string title { get; set; } = "Leasing construction updated";

        /// <example></example>
        public string description { get; set; } = "Leasing construction updated";
    }
}
