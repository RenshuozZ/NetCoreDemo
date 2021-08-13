using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try

            {

                var ctr = 10;

                Console.WriteLine("Main: Start!");

                for (var i = 1; i <= ctr; i++)

                {

                    Console.WriteLine(string.Format("Try {0}: Start!", i));

                    var url = @"https://api-pro-ldc.chinaielts.org/api/speaking/booking";

                    using (var client = new HttpClient())

                    {
                        var request = new HttpRequestMessage(HttpMethod.Post,url);
                        request.Headers.Add("APPCode", "ErrorAPPCode");
                        request.Headers.Add("Accept", "application/json");
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                        //client.DefaultRequestHeaders.TryAddWithoutValidation("APPCode", "69BE49C4-8347-45FD-855A-B3F01324FD92");
                        //client.DefaultRequestHeaders.Clear();
                        //client.DefaultRequestHeaders.TryAddWithoutValidation("APPCode", "ErrorAPPCode");

                        //client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                        var formurlencoded = "{}";

                        var content = new StringContent(formurlencoded, Encoding.UTF8, "application/json");
                        request.Content = content;
                        //request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                        var postAction = client.SendAsync(request);

                        var postResult = postAction.Result;

                        Console.WriteLine("IsSuccessStatusCode=" + postResult.IsSuccessStatusCode);

                        Console.WriteLine("ReasonPhrase=" + postResult.ReasonPhrase);

                        Console.WriteLine("Response_Result=" + postResult.Content.ReadAsStringAsync().Result);

                    }

                    Console.WriteLine(string.Format("Try {0}: Done!", i));

                }

                Console.WriteLine("Main: Done!");

                Console.ReadKey();

            }

            catch (Exception ex)

            {

                throw ex;

            }

        }

    }
}