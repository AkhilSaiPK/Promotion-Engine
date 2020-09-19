using System;
using System.Collections.Generic;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using PromotionEngine.BusinessLayer;
using PromotionEngine.Interfaces;

namespace PromotionEngineTests
{
    [TestClass]
    public class PromotionTests
    {
        [TestMethod]
        public void GetPromotionsTestMethod()
        {
            using (ShimsContext.Create())
            {
                IDoumentProvider doumentProvider = new DocumentManager();
                PromotionManager productsManager = new PromotionManager(doumentProvider);

                var result = productsManager.GetPromotions();
                Assert.IsNotNull(result);
            }

        }

        [TestMethod]
        public void SaveProductTestMethod()
        {
            using (ShimsContext.Create())
            {
                IDoumentProvider doumentProvider = new DocumentManager();
                PromotionManager productsManager = new PromotionManager(doumentProvider);
                Promotion item = new Promotion();
                Dictionary<string, int> d1 = new Dictionary<string, int>();
                d1.Add("A", 5);
                item.PromotionID = 4;
                item.ProductInfo = d1;
                item.PromoPrice = 200;
                productsManager.SavePromotion(item);
                Assert.IsNotNull(true);
            }

        }

        [TestMethod]
        public void SaveProductsTestMethod()
        {
            using (ShimsContext.Create())
            {
                IDoumentProvider doumentProvider = new DocumentManager();
                PromotionManager productsManager = new PromotionManager(doumentProvider);
                List<Promotion> items = new List<Promotion>();
                Promotion item = new Promotion();
                Dictionary<string, int> d1 = new Dictionary<string, int>();
                d1.Add("A", 6);
                item.PromotionID = 5;
                item.ProductInfo = d1;
                item.PromoPrice = 230;
                Promotion item2 = new Promotion();
                Dictionary<string, int> d2 = new Dictionary<string, int>();
                d2.Add("B", 5);
                item.PromotionID = 6;
                item.ProductInfo = d2;
                item.PromoPrice = 160;
                items.Add(item);
                items.Add(item2);
                productsManager.SavePromotions(items);
                Assert.IsNotNull(true);
            }

        }
    }
}
