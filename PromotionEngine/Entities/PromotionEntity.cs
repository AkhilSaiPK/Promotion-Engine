//-----------------------------------------------------------------------
// <copyright file="PromotionEntity.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace PromotionEngine
{
    using System.Collections.Generic;

    /// <summary>
    /// The Promotion class.
    /// </summary>
    public class Promotion
    {
        /// <summary>
        /// Gets or sets Promotion Id Ex:1/2/3
        /// </summary>
        public int PromotionID { get; set; }

        /// <summary>
        /// Gets or sets Product Information Ex:Key as Product ID/Product Name, Value as Number of Occurrences
        /// </summary>
        public Dictionary<string, int> ProductInfo { get; set; }

        /// <summary>
        /// Gets or sets Promotional Price
        /// </summary>
        public decimal PromoPrice { get; set; }
    }
}
