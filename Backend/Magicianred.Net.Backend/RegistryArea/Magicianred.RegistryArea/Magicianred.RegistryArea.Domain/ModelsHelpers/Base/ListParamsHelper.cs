﻿namespace Magicianred.RegistryArea.Domain.ModelsHelpers.Base
{
    /// <summary>
    /// Params to handle list of result
    /// </summary>
    public class ListParamsHelper
	{
		/// <summary>
		/// Page number
		/// </summary>
		public int Page { get; set; }

		/// <summary>
		/// How many item for page
		/// </summary>
		public int ItemsPerPage { get; set; }

		/// <summary>
		/// Field name for sorting
		/// </summary>
		public string SortName { get; set; }

		/// <summary>
		/// Sort order
		/// </summary>
		public string SortOrder { get; set; }
	}
}