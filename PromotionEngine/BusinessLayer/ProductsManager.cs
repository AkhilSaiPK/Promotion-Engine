//-----------------------------------------------------------------------
// <copyright file="ProductsManager.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------

namespace PromotionEngine.BusinessLayer
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using PromotionEngine.Entities;
    using PromotionEngine.Interfaces;

    /// <summary>
    /// The Product Related Methods
    /// </summary>
    public class ProductsManager : IProducts
    {
        /// <summary>
        /// The document provider.
        /// </summary>
        private readonly IDoumentProvider documentProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsManager"/> class
        /// </summary>
        /// <param name="documentProvider">The document provider</param>
        public ProductsManager(IDoumentProvider documentProvider)
        {
            this.documentProvider = documentProvider;
        }

        /// <summary>
        /// Gets the products data.
        /// </summary>
        /// <returns>Returns list of products</returns>
        public ICollection<Product> GetProducts()
        {
            return JsonConvert.DeserializeObject<Products>(this.documentProvider.JonsFileReader(Constants.ProductsDataFile), new JsonSerializerSettings { Formatting = Formatting.Indented, MissingMemberHandling = MissingMemberHandling.Ignore }).ProductsList;
        }

        /// <summary>
        /// Saves the product to the JSON.
        /// </summary>
        /// <param name="saveProductData">The save product data.</param>
        public void SaveProduct(Product saveProductData)
        {
            if (ValidateProductIds(saveProductData.Id))
            {
                var existingProducts = JsonConvert.DeserializeObject<Products>(this.documentProvider.JonsFileReader(Constants.ProductsDataFile), new JsonSerializerSettings { Formatting = Formatting.Indented, MissingMemberHandling = MissingMemberHandling.Ignore }).ProductsList;
                existingProducts.Add(saveProductData);
                string myJsonString = "{ 'ProductsList': " + JsonConvert.SerializeObject(existingProducts) + "}";
                this.documentProvider.JonsFileWriter(Constants.ProductsDataFile, myJsonString);
            }
        }

        /// <summary>
        /// Saves the multiple products to the JSON.
        /// </summary>
        /// <param name="saveProductData">The save product data.</param>
        public void SaveProducts(ICollection<Product> saveProductData)
        {
            if (ValidateProductIds(string.Join(",", saveProductData.Select(x => x.Id).ToArray())))
            {
                var existingProducts = JsonConvert.DeserializeObject<Products>(this.documentProvider.JonsFileReader(Constants.ProductsDataFile), new JsonSerializerSettings { Formatting = Formatting.Indented, MissingMemberHandling = MissingMemberHandling.Ignore }).ProductsList;
                existingProducts.ToList().AddRange(saveProductData);
                string myJsonString = "{ 'ProductsList': " + JsonConvert.SerializeObject(existingProducts) + "}";
                this.documentProvider.JonsFileWriter(Constants.ProductsDataFile, myJsonString);
            }
        }

        /// <summary>
        /// Delete the product from the JSON.
        /// </summary>
        /// <param name="saveProductData">The save product data.</param>
        public void DeleteProduct(Product saveProductData)
        {
            ////Test
        }

        /// <summary>
        /// Validate the Product Id is already Exists
        /// </summary>
        /// <param name="productId">The Product Id</param>
        /// <returns>Returns result</returns>
        public bool ValidateProductIds(string productId)
        {
            return true;
        }
    }
}
