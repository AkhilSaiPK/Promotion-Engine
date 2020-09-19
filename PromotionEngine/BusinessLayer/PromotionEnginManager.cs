//-----------------------------------------------------------------------
// <copyright file="PromotionEnginManager.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------

namespace PromotionEngine.BusinessLayer
{
    using System.Collections.Generic;
    using System.Linq;
    using PromotionEngine.Entities;
    using PromotionEngine.Interfaces;

    /// <summary>
    /// The Promotion Engine Methods
    /// </summary>
    public class PromotionEnginManager : IPromotionEngine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionEnginManager"/> class.
        /// </summary>
        public PromotionEnginManager()
        {
        }

        /// <summary>
        /// Gets the Total Price by orders and promotions.
        /// </summary>
        /// <param name="ordersData">The orders Data.</param>
        /// <param name="promotionsData">The promotions data.</param>
        /// <returns>
        /// The Final Price
        /// </returns>
        public decimal GetTotalPrice(List<Order> ordersData, List<Promotion> promotionsData)
        {
            decimal resultPrice = 0M;
            foreach (Order ord in ordersData)
            {
                resultPrice += GetPrice(ord, promotionsData);
            }

            return resultPrice;
        }

        /// <summary>
        /// Get the Price for each promotion
        /// </summary>
        /// <param name="order">The Order</param>
        /// <param name="promotion">The Promotion</param>
        /// <returns>The Final Price</returns>
        private static decimal GetPrice(Order order, List<Promotion> promotions)
        {
            decimal price = 0M;
            var resultGroup = order.Products.GroupBy(n => n.Id)
                    .ToDictionary(c => c.Key, c => c.Count());
            Dictionary<string, int> finalItems = new Dictionary<string, int>(resultGroup);
            var alreadyAppliedProms = new List<int>();
            foreach (var promotionItem in promotions)
            {
                var appliedPromotion = promotionItem.ProductInfo.All(x => resultGroup.Select(y => y.Key).Contains(x.Key) && resultGroup.Where(z => z.Key == x.Key).FirstOrDefault().Value >= x.Value);
                if (appliedPromotion)
                {
                    var minCount = resultGroup.Where(x => promotionItem.ProductInfo.Any(y => x.Key == y.Key)).OrderBy(x => x.Value).FirstOrDefault().Value;
                    foreach (var item in resultGroup)
                    {
                        var totalItems = item.Value;
                        if (promotionItem.ProductInfo.Where(x => x.Key == item.Key).Count() > 0)
                        {
                            var promotionItems = promotionItem.ProductInfo.Where(x => x.Key == item.Key).FirstOrDefault().Value;
                            if (!alreadyAppliedProms.Contains(promotionItem.PromotionID))
                            {
                                alreadyAppliedProms.Add(promotionItem.PromotionID);
                                while (totalItems >= promotionItems)
                                {
                                    price += promotionItem.PromoPrice;
                                    totalItems -= promotionItems;
                                    finalItems[item.Key] = totalItems;
                                }
                            }
                            else
                            {
                                finalItems[item.Key] = item.Value - minCount;
                            }
                        }
                    }
                }
            }


            foreach (var item in finalItems)
            {
                price += item.Value * order.Products.Where(x => x.Id == item.Key).FirstOrDefault().Price;
            }

            return price;
        }
    }
}
