//-----------------------------------------------------------------------
// <copyright file="Constants.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------
namespace PromotionEngine.Entities
{
    /// <summary>
    /// Application Constants
    /// </summary>
    public sealed class Constants
    {
        #region FileDownload

        /// <summary>
        /// Products data file
        /// </summary>
        public const string ProductsDataFile = "\\Data\\ProductsData.json";

        /// <summary>
        /// Promotions data file
        /// </summary>
        public const string PromotionsDataFile = "\\Data\\PromotionsData.json";
        #endregion

        /// <summary>
        /// Prevents a default instance of the <see cref="Constants"/> class from being created.
        /// </summary>
        private Constants()
        {
        }
    }
}
