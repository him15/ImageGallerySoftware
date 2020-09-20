using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Added
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;
//

namespace ImageGalleryProject
{
    class DataFetcher
    {
        
        // method to fetch the data from the server
        async Task<string> GetDatafromService(string searchstring)
        {
            string readText = null;
            try
            {
                var azure = @"https://imagefetcher20200529182038.azurewebsites.net";

                // get String representation of JSON
                string url = azure + @"/api/fetch_images?query=" + searchstring + "&max_count=5";
                using (HttpClient c = new HttpClient())
                {
                    readText = await c.GetStringAsync(url);
                }
            }
            catch (System.IO.IOException )
            {
                MessageBox.Show("IO Exception Occured");
            }

 
            catch (Exception ex)
            {
                    readText =File.ReadAllText(@"Data/sampleData.json");

            }
           
            return readText;
        }

        // Method 2
        public async Task<List<ImageItem>> GetImageData(string search)
        {
            string data = await GetDatafromService(search);

            // return- convert Json String to the image
            return JsonConvert.DeserializeObject<List<ImageItem>>(data);
        }



    }
}
