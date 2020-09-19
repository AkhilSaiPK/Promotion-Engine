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
    public class Promotions
    {
        /// <summary>
        /// Gets or sets Promotional Price
        /// </summary>
        public ICollection<Promotion> PromotionsList { get; set; }
    }
}
