//-----------------------------------------------------------------------
// <copyright file="IPromotionEngine.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------

namespace PromotionEngine.Interfaces
{
    using System.Collections.Generic;
    using PromotionEngine.Entities;

    /// <summary>
    /// Promotion Engine related methods
    /// </summary>
    public interface IPromotionEngine
    {
        /// <summary>
        /// Gets the Total Price data.
        /// </summary>
        /// <param name="ordersData">The Orders data.</param>
        /// <param name="promotionsData">The Promotions data.</param>
        /// <returns>Returns the price of All Orders</returns>
        decimal GetTotalPrice(List<Order> ordersData, List<Promotion> promotionsData);
    }
}
