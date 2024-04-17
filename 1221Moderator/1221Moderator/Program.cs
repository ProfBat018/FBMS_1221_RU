 using System.Net.Http.Headers;
 using System.Text;
 using System.Web;

 var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);
 
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "a812e924f3a04fa9b01959363111d7c4");
 
            // queryString["autocorrect"] = "{boolean}";
            // queryString["PII"] = "{boolean}";
            // queryString["listId"] = "{string}";
            // queryString["classify"] = "True";
            // queryString["language"] = "{string}";
            var uri = "https://westus.api.cognitive.microsoft.com/contentmoderator/moderate/v1.0/ProcessText/Screen?" + queryString;

            HttpResponseMessage response;

            
            byte[] byteData = Encoding.UTF8.GetBytes("Is this a crap email abcdef@abcd.com, phone: 6657789887, IP: 255.255.255.255, 1 Microsoft Way, Redmond, WA 98052");

            using (var content = new ByteArrayContent(byteData))
            {
               content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
               response = await client.PostAsync(uri, content);

              var res = await response.Content.ReadAsStringAsync();

              Console.WriteLine(res);
            }

 
        