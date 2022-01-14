using Magicianred.RegistryArea.Domain.ModelsHelpers.Base;
using System;

namespace Magicianred.RegistryArea.Domain.ModelsHelpers
{
    /// <summary>
    /// Parameter filter and sort for RegistryApplication
    /// </summary>
    public class RegistryApplicationParamsHelper : ListParamsHelper
    {
        /// <summary>
        /// Filter for id
        /// </summary>
        public long? ApplicationId { get; set; }
        /// <summary>
        /// Comparator for filter id
        /// </summary>
        public string ApplicationIdComparator { get; set; }

        /// <summary>
        /// Filter for name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Comporator for filter name
        /// </summary>
        public string NameComparator { get; set; }

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
