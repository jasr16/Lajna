using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Lajna.Model
{
    public class FilePicking
    {
        public static async Task<FileResult> PickAndShow(PickOptions options)
        {
            try
            {
                var result = await FilePicker.PickAsync(options);
                if (result != null)
                {
                    string Text = $"File Name: {result.FileName}";
                }

                return result;
            }
            catch (Exception ex)
            {
                // The user canceled or something went wrong
            }

            return null;
        }

        public static string[] FindAllMp3s()
        {
            // string[] listOfFiles = Directory.GetFiles("/storage/emulated/0/Android/data/com.companyname.app/Music/");
            string[] listOfFiles = Directory.GetFiles("/storage/emulated/0/Music/");
            string[] listOfSongs = listOfFiles.Where(x => x.EndsWith(".mp3")).ToArray();
            return listOfSongs;
        }
    }
}
