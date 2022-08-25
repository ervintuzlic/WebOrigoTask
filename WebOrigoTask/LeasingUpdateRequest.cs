using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public class LeasingUpdateRequest
    {
        /// <summary>
        /// Device ID
        /// </summary>
        /// <example>NW-H-20-0017</example>
        [Key]
        public string deviceId { get; set; }

        /// <summary>
        /// Device trainings
        /// </summary>
        /// <example>20</example>
        public int deviceTrainings { get; set; }

    }
}
