using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public sealed class LeasingPeriods
    {
        /// <summary>
        /// Leasing Construction Id
        /// </summary>
        [Key]
        public int leasingConstructionId { get; set; }

        /// <summary>
        /// Leasing Construction Maximum Training
        /// </summary>
        public int leasingConstructionMaximumTraining { get; set; }

        /// <summary>
        /// Leasing Construction Maximum Date
        /// </summary>
        public string leasingConstructionMaximumDate { get; set; } = string.Empty;
    }
}
