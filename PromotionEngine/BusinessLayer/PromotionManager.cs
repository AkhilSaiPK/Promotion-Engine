//-----------------------------------------------------------------------
// <copyright file="PromotionManager.cs" company="Maersk">
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
    /// The Promotion Related Methods
    /// </summary>
    public class PromotionManager : IPromotions
    {
        /// <summary>
        /// The document provider.
        /// </summary>
        private readonly IDoumentProvider documentProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionManager"/> class
        /// </summary>
        /// <param name="documentProvider">The document provider</param>
        public PromotionManager(IDoumentProvider documentProvider)
        {
            this.documentProvider = documentProvider;
        }

        /// <summary>
        /// Gets the Promotions data.
        /// </summary>
        /// <returns>Returns list of Promotions</returns>
        public ICollection<Promotion> GetPromotions()
        {
            return JsonConvert.DeserializeObject<Promotions>(this.documentProvider.JonsFileReader(Constants.PromotionsDataFile), new JsonSerializerSettings { Formatting = Formatting.Indented, MissingMemberHandling = MissingMemberHandling.Ignore }).PromotionsList;
        }

        /// <summary>
        /// Saves the Promotion to the JSON.
        /// </summary>
        /// <param name="savePromotionData">The save Promotion data.</param>
        public void SavePromotion(Promotion savePromotionData)
        {
            if (ValidatePromotionIds(savePromotionData.PromotionID.ToString()))
            {
                var existingPromotions = JsonConvert.DeserializeObject<Promotions>(this.documentProvider.JonsFileReader(Constants.PromotionsDataFile), new JsonSerializerSettings { Formatting = Formatting.Indented, MissingMemberHandling = MissingMemberHandling.Ignore }).PromotionsList;
                existingPromotions.Add(savePromotionData);
                string myJsonString = "{ 'PromotionsList': " + JsonConvert.SerializeObject(existingPromotions) + "}";
                this.documentProvider.JonsFileWriter(Constants.PromotionsDataFile, myJsonString);
            }
        }

        /// <summary>
        /// Saves the multiple Promotion to the JSON.
        /// </summary>
        /// <param name="savePromotionData">The save Promotion data.</param>
        public void SavePromotions(ICollection<Promotion> savePromotionData)
        {
            if (ValidatePromotionIds(string.Join(",", savePromotionData.Select(x => x.PromotionID.ToString()).ToArray())))
            {
                var existingPromotions = JsonConvert.DeserializeObject<Promotions>(this.documentProvider.JonsFileReader(Constants.PromotionsDataFile), new JsonSerializerSettings { Formatting = Formatting.Indented, MissingMemberHandling = MissingMemberHandling.Ignore }).PromotionsList;
                existingPromotions.ToList().AddRange(savePromotionData);
                string myJsonString = "{ 'PromotionsList': " + JsonConvert.SerializeObject(existingPromotions) + "}";
                this.documentProvider.JonsFileWriter(Constants.PromotionsDataFile, myJsonString);
            }
        }

        /// <summary>
        /// Delete the Promotion from the JSON.
        /// </summary>
        /// <param name="savePromotionId">The save Promotion data.</param>
        public void DeleteProduct(string savePromotionId)
        {
            ////Test
        }

        /// <summary>
        /// Validate the Promotion Id is already Exists
        /// </summary>
        /// <param name="promotionId">The Promotion Id</param>
        /// <returns>Returns result</returns>
        public bool ValidatePromotionIds(string promotionId)
        {
            return true;
        }
    }
}
