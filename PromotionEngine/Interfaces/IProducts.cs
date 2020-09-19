//-----------------------------------------------------------------------
// <copyright file="IProducts.cs" company="Maersk">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace PromotionEngine.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Products related methods
    /// </summary>
    public interface IProducts
    {
        /// <summary>
        /// Gets the products data.
        /// </summary>
        /// <returns>Returns list of products</returns>
        ICollection<Product> GetProducts();

        /// <summary>
        /// Saves the product to the JSON.
        /// </summary>
        /// <param name="saveProductData">The save product data.</param>
        void SaveProduct(Product saveProductData);

        /// <summary>
        /// Saves the multiple products to the JSON.
        /// </summary>
        /// <param name="saveProductData">The save product data.</param>
        void SaveProducts(ICollection<Product> saveProductData);

        /// <summary>
        /// Delete the product from the JSON.
        /// </summary>
        /// <param name="saveProductData">The save product data.</param>
        void DeleteProduct(Product saveProductData);

        /// <summary>
        /// Validate the Product Id is already Exists
        /// </summary>
        /// <param name="productId">The Product Id</param>
        /// <returns>Returns result</returns>
        bool ValidateProductIds(string productId);
    }
}
