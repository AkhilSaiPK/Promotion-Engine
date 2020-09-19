//-----------------------------------------------------------------------
// <copyright file="ProductEntity.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace PromotionEngine
{
    using System.Collections.Generic;

    /// <summary>
    /// The Product Class.
    /// </summary>
    public class Products
    {
        /// <summary>
        /// Gets or sets Product Price
        /// </summary>
        public ICollection<Product> ProductsList { get; set; }
    }
}
