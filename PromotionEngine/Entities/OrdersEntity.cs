//-----------------------------------------------------------------------
// <copyright file="OrdersEntity.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace PromotionEngine.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The Order Class.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets Order Id 
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// Gets or sets Product List.
        /// </summary>
        public List<Product> Products { get; set; }
    }
}
