using Magicianred.StagingArea.Domain.ModelsHelpers.Base;
using System;

namespace Magicianred.StagingArea.Domain.ModelsHelpers
{
    /// <summary>
    /// Parameter filter and sort for RegistryEventType
    /// </summary>
    public class RegistryEventTypeParamsHelper : ListParamsHelper
    {
        /// <summary>
        /// Filter for id
        /// </summary>
        public long? EventTypeId { get; set; }
        /// <summary>
        /// Comparator for filter id
        /// </summary>
        public string EventTypeIdComparator { get; set; }

        /// <summary>
        /// Filter for name
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// Comporator for filter name
        /// </summary>
        public string SystemNameComparator { get; set; }

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
