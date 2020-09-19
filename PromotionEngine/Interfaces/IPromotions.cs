//-----------------------------------------------------------------------
// <copyright file="IPromotions.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------

namespace PromotionEngine.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Promotion related methods
    /// </summary>
    public interface IPromotions
    {
        /// <summary>
        /// Gets the Promotions data.
        /// </summary>
        /// <returns>Returns list of Promotions</returns>
        ICollection<Promotion> GetPromotions();

        /// <summary>
        /// Saves the Promotion to the JSON.
        /// </summary>
        /// <param name="savePromotionData">The save Promotion data.</param>
        void SavePromotion(Promotion savePromotionData);

        /// <summary>
        /// Saves the multiple Promotion to the JSON.
        /// </summary>
        /// <param name="savePromotionData">The save Promotion data.</param>
        void SavePromotions(ICollection<Promotion> savePromotionData);

        /// <summary>
        /// Delete the Promotion from the JSON.
        /// </summary>
        /// <param name="savePromotionId">The save Promotion data.</param>
        void DeleteProduct(string savePromotionId);

        /// <summary>
        /// Validate the Promotion Id is already Exists
        /// </summary>
        /// <param name="promotionId">The Promotion Id</param>
        /// <returns>Returns result</returns>
        bool ValidatePromotionIds(string promotionId);
    }
}
