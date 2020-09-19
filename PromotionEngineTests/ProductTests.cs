using System;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Interfaces;
using PromotionEngine.Fakes;
using PromotionEngine.BusinessLayer.Fakes;
using PromotionEngine.BusinessLayer;
using PromotionEngine.Entities;
using PromotionEngine;
using System.Collections.Generic;

namespace PromotionEngineTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void GetProductsTestMethod()
        {
            using (ShimsContext.Create())
            {
                IDoumentProvider doumentProvider = new DocumentManager();
                ProductsManager productsManager = new ProductsManager(doumentProvider);

                var result = productsManager.GetProducts();
                Assert.IsNotNull(result);
            }

        }

        [TestMethod]
        public void SaveProductTestMethod()
        {
            using (ShimsContext.Create())
            {
                IDoumentProvider doumentProvider = new DocumentManager();
                ProductsManager productsManager = new ProductsManager(doumentProvider);
                Product item = new Product();
                item.Id = "E";
                item.Price = 65;
                productsManager.SaveProduct(item);
                Assert.IsNotNull(true);
            }

        }

        [TestMethod]
        public void SaveProductsTestMethod()
        {
            using (ShimsContext.Create())
            {
                IDoumentProvider doumentProvider = new DocumentManager();
                ProductsManager productsManager = new ProductsManager(doumentProvider);
                List<Product> items = new List<Product>();
                Product item1 = new Product();
                item1.Id = "F";
                item1.Price = 60;
                Product item2 = new Product();
                item2.Id = "G";
                item2.Price = 70;
                items.Add(item1);
                items.Add(item2);
                productsManager.SaveProducts(items);
                Assert.IsNotNull(true);
            }

        }
    }
}
