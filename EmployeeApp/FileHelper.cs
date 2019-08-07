using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace EmployeeApp
{
   static class FileHelper
    {
        public async static void WriteTextFile(string filename,
            string content) {
           var storageFolder= ApplicationData.Current.LocalFolder;

            var textFile= await storageFolder.CreateFileAsync(filename, CreationCollisionOption.OpenIfExists);

            var textstream=await textFile.OpenAsync(FileAccessMode.ReadWrite);

            var textWriter = new DataWriter(textstream);
            textWriter.WriteString(content);

            await textWriter.StoreAsync();
        }
    }
}
