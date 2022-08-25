using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public sealed class LeasingPeriodsComputed
    {
        /// <summary>
        /// Leasing Construction Id
        /// </summary>
        [Key]
        [Required]
        public int leasingConstructionId { get; set; }

        /// <summary>
        /// leasing Construction Maximum Training
        /// </summary>
        public int leasingConstructionMaximumTraining { get; set; }

        /// <summary>
        /// leasing Construction Maximum Date
        /// </summary>
        public string leasingConstructionMaximumDate { get; set; } = string.Empty;

        /// <summary>
        /// leasing Actual Period Start Date
        /// </summary>
        public string leasingActualPeriodStartDate { get; set; } = string.Empty;

        /// <summary>
        /// leasing Next Check
        /// </summary>
        public string leasingNextCheck { get; set; } = string.Empty;
    }
}
