using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace minTools
{
    namespace FTP
    {
        static class FTPToolkit
        {
            public static List<string> getFTPDirectoryContents(string FTPAddress, string FTPUser, string FTPPass)
            {
                //check directory contents
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPAddress);
                request.KeepAlive = true;
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(FTPUser, FTPPass);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                //get list of csvs
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                List<string> directories = new List<string>();

                //create the output
                string line = reader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    directories.Add(line);
                    line = reader.ReadLine();
                }
                reader.Close();
                response.Dispose();
                return directories;
            }

            public static List<string> getFTPDirectoryDetails(string FTPAddress, string FTPUser, string FTPPass)
            {
                //check directory contents
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPAddress);
                request.KeepAlive = true;
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                request.Credentials = new NetworkCredential(FTPUser, FTPPass);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                //get list of csvs
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                List<string> directories = new List<string>();

                //create the output
                string line = reader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    directories.Add(line);
                    line = reader.ReadLine();
                }
                reader.Close();
                response.Dispose();
                return directories;
            }

            public static void uploadToFTP(string FTPAddress, string FTPUser, string FTPPass, string fileName)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPAddress);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(FTPUser, FTPPass);

                StreamReader sourceStream = new StreamReader(fileName);
                //byte[] fileContents = GetEncoding.GetBytes(sourceStream.ReadToEnd());  //automatically gets the encoding
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();


                response.Close();
            }

            public static bool downloadFTPFile(string FTPAddress, string FTPUser, string FTPPass, string fileName, string downloadFolder, bool deleteAfterDownload = false)
            {
                // Get the object used to communicate with the server.  
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPAddress + fileName);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(FTPUser, FTPPass);

                //copy to a file
                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(downloadFolder + fileName))
                {
                    ftpStream.CopyTo(fileStream);
                }

                //possibly delete from ftp after download
                if (deleteAfterDownload)
                {
                    FtpWebRequest deleteRequest = (FtpWebRequest)WebRequest.Create(FTPAddress + fileName);
                    deleteRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                    deleteRequest.Credentials = new NetworkCredential(FTPUser, FTPPass);
                    deleteRequest.GetResponse().Close();
                }
                return true;
            }

            public static bool downloadFTPFiles(string FTPAddress, string FTPUser, string FTPPass, string[] fileName, string downloadFolder)
            {
                // Get the object used to communicate with the server.  
                foreach (string file in fileName)
                {
                    //copy to a file
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPAddress + file);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    request.Credentials = new NetworkCredential(FTPUser, FTPPass);
                    using (Stream ftpStream = request.GetResponse().GetResponseStream())
                    using (Stream fileStream = File.Create(downloadFolder + file))
                    {
                        ftpStream.CopyTo(fileStream);
                    }
                }
                return true;
            }

            public static string deleteFromFTP(string FTPAddress, string FTPUser, string FTPPass, string fileName)
            {
                // Get the object used to communicate with the server.  
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPAddress + fileName);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                request.Credentials = new NetworkCredential(FTPUser, FTPPass);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    return response.StatusDescription;
                }
            }
        }

    }
}
