using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;

namespace minTools
{
    namespace Email
    {
        public class SMTPStatusChecker
        {
            public bool testConnection(string hostname, int port, bool enableSSL, out string outputMessage)
            {
                outputMessage = "";
                using (var client = new TcpClient())
                {
                    try
                    {
                        client.Connect(hostname, port);
                    }
                    catch (Exception e)
                    {
                        outputMessage = "Connection Failed: " + e.Message;
                        return false;
                    }
                    outputMessage = "Connected";

                    if (enableSSL)
                        using (var stream = client.GetStream())
                        using (var sslStream = new SslStream(stream))
                        {
                            try
                            {
                                sslStream.AuthenticateAsClient(hostname);
                            }
                            catch (Exception e)
                            {
                                outputMessage = "Connection via SSL failed: " + e.Message;
                                return false;
                            }

                            using (var writer = new StreamWriter(sslStream))
                            using (var reader = new StreamReader(sslStream))
                            {
                                writer.WriteLine("EHLO " + hostname);
                                writer.Flush();
                                outputMessage = "Connected via SSL";

                                if (reader.ReadLine().Contains("220")) //GMail responds with: 220 mx.google.com ESMTP
                                    return true;
                                return false;
                            }
                        }
                    else
                        return client.Connected;
                }
            }

            public bool testCredentials(string hostname, int port, string user, string pass, bool enableSSL, out string outputMessage)
            {
                if (!testConnection(hostname, port, enableSSL, out outputMessage))
                    return false;

                return B2BFamily.SmtpValidation.Lib.SmtpHelper.ValidateCredentials(user, pass, hostname, port, enableSSL);
            }
        }
    }
}
