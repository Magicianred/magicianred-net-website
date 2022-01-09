using Magicianred.StagingArea.Domain.ModelsHelpers.Base;
using System;

namespace Magicianred.StagingArea.Domain.ModelsHelpers
{
    /// <summary>
    /// Parameter filter and sort for RegistryEntity
    /// </summary>
    public class RegistryEntityParamsHelper : ListParamsHelper
    {
        /// <summary>
        /// Filter for id
        /// </summary>
        public long? EntityId { get; set; }
        /// <summary>
        /// Comparator for filter id
        /// </summary>
        public string EntityIdComparator { get; set; }

        /// <summary>
        /// Filter for id
        /// </summary>
        public long? EntityTypeId { get; set; }
        /// <summary>
        /// Comparator for filter id
        /// </summary>
        public string EntityTypeIdComparator { get; set; }

        /// <summary>
        /// Filter for create date
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Comparator for filter create date
        /// </summary>
        public string CreateDateComparator { get; set; }
    }
}
