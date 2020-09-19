//-----------------------------------------------------------------------
// <copyright file="IDoumentProvider.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------
namespace PromotionEngine.Interfaces
{
    using System.IO;

    /// <summary>
    /// Doc provider
    /// </summary>
    public interface IDoumentProvider
    {
        /// <summary>
        /// Downloads the file from Data folder.
        /// </summary>
        /// <param name="filepath">The file path.</param>
        /// <returns>
        /// Stream object for file
        /// </returns>
        System.Threading.Tasks.Task<MemoryStream> DownloadFileAsync(string filepath);

        /// <summary>
        ///  The JSON file reader.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>The JSON string</returns>
        string JonsFileReader(string filePath);

        /// <summary>
        ///  The JSON file writer.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="itemsData">The new data.</param>
        /// <returns>The JSON string</returns>
        void JonsFileWriter(string filePath, string itemsData);
    }
}
