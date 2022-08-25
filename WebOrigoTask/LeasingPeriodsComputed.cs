using System.ComponentModel.DataAnnotations;

namespace WebOrigoTask
{
    public sealed class LeasingPeriodsComputed
    {
        /// <summary>
        /// Leasing Construction Id
        /// </summary>
        /// <example>51342268</example>
        [Key]
        [Required]
        public int leasingConstructionId { get; set; }

        /// <summary>
        /// leasing Construction Maximum Training
        /// </summary>
        /// <example>1000</example>
        public int leasingConstructionMaximumTraining { get; set; }

        /// <summary>
        /// leasing Construction Maximum Date
        /// </summary>
        /// <example>2021-06-01</example>
        public string leasingConstructionMaximumDate { get; set; } = string.Empty;

        /// <summary>
        /// leasing Actual Period Start Date
        /// </summary>
        /// <example>2021-12-01</example>
        public string leasingActualPeriodStartDate { get; set; } = string.Empty;

        /// <summary>
        /// leasing Next Check
        /// </summary>
        /// <example>2021-12-01 17:30:00</example>
        public string leasingNextCheck { get; set; } = string.Empty;
    }
}
