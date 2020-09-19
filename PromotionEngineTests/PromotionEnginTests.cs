using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using PromotionEngine.BusinessLayer;
using PromotionEngine.Entities;
using PromotionEngine.Interfaces;

namespace PromotionEngineTests
{
    [TestClass]
    public class PromotionEnginTests
    {
        [TestMethod]
        public void GetTotalPriceScenarioATestMethod()
        {
            IDoumentProvider doumentProvider = new DocumentManager();
            List<Order> orders = new List<Order>();
            ProductsManager productsManager = new ProductsManager(doumentProvider);

            var products =productsManager.GetProducts();
            List<Product> finalProducts = new List<Product>();
            finalProducts.Add(products.Where(s => s.Id == "A").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "C").FirstOrDefault());

            Order orderOne = new Order();
            orderOne.OrderID = 1;
            orderOne.Products = finalProducts;
            orders.Add(orderOne);
           
            PromotionManager promotionsManager = new PromotionManager(doumentProvider);
            PromotionEnginManager promotionEnginManager = new PromotionEnginManager();
            var promotions = promotionsManager.GetPromotions();
            var result = promotionEnginManager.GetTotalPrice(orders, new List<Promotion>(promotions));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetTotalPriceScenarioBTestMethod()
        {
            IDoumentProvider doumentProvider = new DocumentManager();
            List<Order> orders = new List<Order>();
            ProductsManager productsManager = new ProductsManager(doumentProvider);

            var products = productsManager.GetProducts();
            List<Product> finalProducts = new List<Product>();
            finalProducts.Add(products.Where(s => s.Id == "A").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "A").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "A").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "A").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "A").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());

            finalProducts.Add(products.Where(s => s.Id == "C").FirstOrDefault());

            Order orderOne = new Order();
            orderOne.OrderID = 1;
            orderOne.Products = finalProducts;
            orders.Add(orderOne);

            PromotionManager promotionsManager = new PromotionManager(doumentProvider);
            PromotionEnginManager promotionEnginManager = new PromotionEnginManager();
            var promotions = promotionsManager.GetPromotions();
            var result = promotionEnginManager.GetTotalPrice(orders, new List<Promotion>(promotions));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetTotalPriceScenarioCTestMethod()
        {
            IDoumentProvider doumentProvider = new DocumentManager();
            List<Order> orders = new List<Order>();
            ProductsManager productsManager = new ProductsManager(doumentProvider);

            var products = productsManager.GetProducts();
            List<Product> finalProducts = new List<Product>();
            finalProducts.Add(products.Where(s => s.Id == "A").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "A").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "A").FirstOrDefault());

            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "B").FirstOrDefault());

            finalProducts.Add(products.Where(s => s.Id == "C").FirstOrDefault());
            finalProducts.Add(products.Where(s => s.Id == "D").FirstOrDefault());
            Order orderOne = new Order();
            orderOne.OrderID = 1;
            orderOne.Products = finalProducts;
            orders.Add(orderOne);

            PromotionManager promotionsManager = new PromotionManager(doumentProvider);
            PromotionEnginManager promotionEnginManager = new PromotionEnginManager();
            var promotions = promotionsManager.GetPromotions();
            var result = promotionEnginManager.GetTotalPrice(orders, new List<Promotion>(promotions));
            Assert.IsNotNull(result);
        }
    }
}
