//-----------------------------------------------------------------------
// <copyright file="ProductEntity.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace PromotionEngine
{
    /// <summary>
    /// The Product Class.
    /// </summary>
    public class Product
    {
        /// <summary>
        ///  Gets or sets Product Id Ex:A/B/C
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Product Price
        /// </summary>
        public decimal Price { get; set; }
    }
}
