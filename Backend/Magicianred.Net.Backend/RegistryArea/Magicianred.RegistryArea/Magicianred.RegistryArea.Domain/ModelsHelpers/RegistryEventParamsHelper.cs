using Magicianred.RegistryArea.Domain.ModelsHelpers.Base;
using System;

namespace Magicianred.RegistryArea.Domain.ModelsHelpers
{
    /// <summary>
    /// Parameter filter and sort for RegistryEvent
    /// </summary>
    public class RegistryEventParamsHelper : ListParamsHelper
    {
        /// <summary>
        /// Filter for id
        /// </summary>
        public long? EventId { get; set; }
        /// <summary>
        /// Comparator for filter id
        /// </summary>
        public string EventIdComparator { get; set; }

        /// <summary>
        /// Filter for type id
        /// </summary>
        public long? RegistryEventTypeId { get; set; }
        /// <summary>
        /// Comparator for filter type id
        /// </summary>
        public string RegistryEventTypeIdComparator { get; set; }

        ///// <summary>
        ///// Filter for id
        ///// </summary>
        //public long? EntityTypeId { get; set; }
        ///// <summary>
        ///// Comparator for filter id
        ///// </summary>
        //public string EntityTypeIdComparator { get; set; }

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
