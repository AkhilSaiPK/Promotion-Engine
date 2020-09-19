//-----------------------------------------------------------------------
// <copyright file="DocumentManager.cs" company="Maersk">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Siva Kumar Reddy</author>
//-----------------------------------------------------------------------

namespace PromotionEngine.BusinessLayer
{
    using System.IO;
    using System.Reflection;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using PromotionEngine.Interfaces;

    /// <summary>
    /// The Document Operation Methods
    /// </summary>
    public class DocumentManager : IDoumentProvider
    {
        /// <summary>
        /// Downloads the file from azure.
        /// </summary>
        /// <param name="filepath">The file path.</param>
        /// <returns>
        /// Stream object for file
        /// </returns>
        public async System.Threading.Tasks.Task<MemoryStream> DownloadFileAsync(string filepath)
        {
            var dirPath = Assembly.GetExecutingAssembly().Location;
            var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filenameP = buildDir + @"" + filepath + "";
            MemoryStream memStream = new MemoryStream();
            using (FileStream sourceStream = File.Open(filenameP, FileMode.OpenOrCreate))
            {
                await sourceStream.CopyToAsync(memStream);
                memStream.Position = 0L;
            }

            return memStream;
        }

        /// <summary>
        ///  The JSON file reader.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>The JSON string</returns>
        public string JonsFileReader(string filePath)
        {
            ////get the Json filepath
            var stream = Task.Run(() => this.DownloadFileAsync(filePath)).Result;
            stream.Position = 0;
            var serializer = new JsonSerializer();
            using (StreamReader metadatastream = new StreamReader(stream))
            {
                using (var jsonTextReader = new JsonTextReader(metadatastream))
                {
                    var result = serializer.Deserialize(jsonTextReader);
                    return result.ToString();
                }
            }
        }

        /// <summary>
        ///  The JSON file writer.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>The JSON string</returns>
        public void JonsFileWriter(string filePath, string itemsData)
        {
            var dirPath = Assembly.GetExecutingAssembly().Location;
            var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filenameP = buildDir + @"" + filePath + "";
            //export data to json file. 
            using (TextWriter tw = new StreamWriter(filenameP))
            {
                tw.WriteLine(itemsData);
            };
        }
    }
}
