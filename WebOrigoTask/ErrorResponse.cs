using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public class ErrorResponse
    {
        /// <example>Title of the error</example>
        [Key]
        public string title { get; set; } = "Title of the error";

        /// <example>Brief description about the error's nature</example>
        public string description { get; set; } = "Brief description about the error's nature";
    }
}
