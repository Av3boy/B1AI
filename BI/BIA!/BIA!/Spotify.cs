using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class Spotify
    {

        public static void NextSong()
        {
            string url = "http://unkn0wns.xyz/spotifynext.php";

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

            string result1 = new WebClient().DownloadString(url);
        }

        public static void PauseSong()
        {
            string url = "http://unkn0wns.xyz/spotifypause.php";

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

            string result1 = new WebClient().DownloadString(url);
        }

        public static void PreviousSong()
        {
            string url = "http://unkn0wns.xyz/spotifyprevious.php";

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

            string result1 = new WebClient().DownloadString(url);
        }
        public static void ResumePlay()
        {
            string url = "http://unkn0wns.xyz/spotifyresume.php";

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

            string result1 = new WebClient().DownloadString(url);
        }
    }

}
