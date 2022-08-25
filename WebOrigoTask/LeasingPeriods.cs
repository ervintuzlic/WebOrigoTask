using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public sealed class LeasingPeriods
    {
        /// <summary>
        /// Leasing Construction Id
        /// </summary>
        /// <example>51342268</example>
        [Key]
        public int leasingConstructionId { get; set; }

        /// <summary>
        /// Leasing Construction Maximum Training
        /// </summary>
        /// <example>1000</example>
        public int leasingConstructionMaximumTraining { get; set; }

        /// <summary>
        /// Leasing Construction Maximum Date
        /// </summary>
        /// <example>2021-06-01</example>
        public string leasingConstructionMaximumDate { get; set; } = string.Empty;
    }
}
