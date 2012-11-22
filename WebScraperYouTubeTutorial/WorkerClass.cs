using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;





namespace WebScraperYouTubeTutorial
{


    class WorkerClass
    {

        private static string sSourceCode = "";
        //private static StreamWriter sw = null;


        public static string GetSourceCode(string url)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());


            sSourceCode = reader.ReadToEnd();



            reader.Close();
            response.Close();
            


            return sSourceCode;
        }



        //remember to add the actual file at the end of the path.....
        //   not including the filename.txt in the directory is what was causing permission errors.....
        public static void WriteSourceToText(string sSourceCode)
        {

            string sPath = @"C:\Users\Public\ScrapedSites\Temp\tmp.txt";
            //FileStream fs = new FileStream(sPath, FileMode.Create, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(sPath, false);
            //StreamWriter sw = File.CreateText(sPath);

            StreamWriter sw = new StreamWriter(sPath);
            sw.Write(sSourceCode);
            sw.Close();

        }




        public static void ParseData(string sSourceCode)
        {

            string sURL = "";

            int iStartIndex = sSourceCode.IndexOf("<div id=\"comic\">");
            int iEndIndex;


            sSourceCode = sSourceCode.Substring(iStartIndex, sSourceCode.Length - iStartIndex);



            iStartIndex = sSourceCode.IndexOf("img src=");
            sSourceCode = sSourceCode.Substring(iStartIndex, sSourceCode.Length - iStartIndex);



            //define the pattern of the start of the string
            //define the pattern of the end of the string
            //iStartIndex starts at [0] position,   h, 
            //iEndIndex starts a [0] position,    .
            //    so + 4 index positions is required to include the entire     .jpg
            iStartIndex = sSourceCode.IndexOf("http://");
            iEndIndex = sSourceCode.IndexOf(".jpg", iStartIndex);
            sURL = sSourceCode.Substring(iStartIndex, (iEndIndex + 4) - (iStartIndex));





            string sPath = @"C:\Users\Public\ScrapedSites\Temp\tmp2.txt";
            StreamWriter sw = new StreamWriter(sPath);
            sw.Write(sSourceCode);
            sw.Close();






            sPath = @"C:\Users\Public\ScrapedSites\Temp\URL.txt";
            StreamWriter sw2 = new StreamWriter(sPath);
            sw2.Write(sURL);
            sw2.Close();


            //a Uri is a URL object
            //Uri is required for use by WebClient
            Uri realLink = new Uri(sURL);
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(realLink, @"C:\Users\Public\Scrapedsites\Temp\antics2.jpg");






        }








    }






}
