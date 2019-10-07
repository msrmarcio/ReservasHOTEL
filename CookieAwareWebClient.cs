using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Btg.PocReserva.UI
{
    public class CookieAwareWebClient : WebClient
    {
        public void Login(string loginPageAddress, NameValueCollection loginData)
        {
            CookieContainer container;

            var request = (HttpWebRequest)WebRequest.Create(loginPageAddress);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            var query = string.Join("&",
              loginData.Cast<string>().Select(key => $"{key}={loginData[key]}"));

            var buffer = Encoding.ASCII.GetBytes(query);
            request.ContentLength = buffer.Length;
            var requestStream = request.GetRequestStream();
            requestStream.Write(buffer, 0, buffer.Length);
            requestStream.Close();

            container = request.CookieContainer = new CookieContainer();

            var response = request.GetResponse();
            response.Close();
            CookieContainer = container;
        }
        public string Disponibilidade(string url, NameValueCollection strData)
        {
            WebClient clientes = new WebClient();
            string json = clientes.DownloadString(url);
            string res = "";

            var disponibilidade = JsonConvert.DeserializeObject<Disponibilidade>(json.Replace("RetornaDisponibilidade(", "").Replace(")", ""));

            if (disponibilidade.codeReturn == "1" && Convert.ToInt32(disponibilidade.MaximoDias) >= 1)
            {
                res = url.Substring(8, 4);

                Debug.Print(new string('*', 80));
                Debug.Print("ENCONTRADO RESERVA DISPONIVEL: " + url.Substring(8, 4) + " ||  " + DateTime.Now.ToString()); 
                Debug.Print(new string('*', 80));

                if (url.Contains("4014"))
                {
                    Debug.Print(new string('=', 80));
                    Debug.Print("GUARUJA ENCONTRADO RESERVA DISPONIVEL: " + url.Substring(8, 4));
                    Debug.Print(new string('=', 80));

                    return "4014";
                }
            }

            return res;
        }

        public CookieAwareWebClient(CookieContainer container)
        {
            CookieContainer = container;
        }

        public CookieAwareWebClient()
          : this(new CookieContainer())
        { }

        public CookieContainer CookieContainer { get; private set; }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = (HttpWebRequest)base.GetWebRequest(address);
            request.CookieContainer = CookieContainer;
            return request;
        }


        public string HttpPostRequest(string url, Dictionary<string, string> postParameters)
        {
            string postData = "";

            foreach (string key in postParameters.Keys)
            {
                postData += HttpUtility.UrlEncode(key) + "="
                      + HttpUtility.UrlEncode(postParameters[key]) + "&";
            }

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            myHttpWebRequest.Method = "POST";

            byte[] data = Encoding.ASCII.GetBytes(postData);

            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = data.Length;

            Stream requestStream = myHttpWebRequest.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            Stream responseStream = myHttpWebResponse.GetResponseStream();

            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);

            string pageContent = myStreamReader.ReadToEnd();

            myStreamReader.Close();
            responseStream.Close();

            myHttpWebResponse.Close();

            return pageContent;
        }

        public void RetornaHotel(/*string url, NameValueCollection strData*/)
        {
            CookieContainer container;
            string url = @"https://4001.afpesp.org.br/RetornaHotel?callback=RetornaHotel&c=3&m=R1FGUVk5c0dtVmNhV3RCZ0phTTBDYk1IME1wSjU3a2lyMERZbjBVU1FIUU9YNFl3QTFhN1NnVmdHaW5PVUdtVmNzRGRFRk9JMWxXcGFpaTVVejlrRWlCR2pqUUgxb3hiUE8rUmdVVWF3OHF3NjgxMjkx&guid=5613adbd-ecd2-4b69-9240-aa8bb4447470&_=1569253941474";

            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            //var query = string.Join("&",
            // strData.Cast<string>().Select(key => $"{key}={strData[key]}"));

            var buffer = Encoding.ASCII.GetBytes(new char[10]);
            request.ContentLength = buffer.Length;
            var requestStream = request.GetRequestStream();
            requestStream.Write(buffer, 0, buffer.Length);
            requestStream.Close();

            container = request.CookieContainer = new CookieContainer();

            var response = request.GetResponse();
            response.Close();
            CookieContainer = container;



        }
        public void RetornarPeriodos()
        {
            WebClient webClient = new WebClient();
            webClient.BaseAddress = @"https://4005.afpesp.org.br/RetornaPeriodos?callback=RetornaPeriodos&guid=5613adbd-ecd2-4b69-9240-aa8bb4447470&m=R1FGUVk5c0dtVmNhV3RCZ0phTTBDYk1IME1wSjU3a2lyMERZbjBVU1FIUU9YNFl3QTFhN1NnVmdHaW5PVUdtVmNzRGRFRk9JMWxXcGFpaTVVejlrRWlCR2pqUUgxb3hiUE8rUmdVVWF3OHF3NjgxMjkx&_=1569270381462";
            Uri uri = new Uri(webClient.BaseAddress);


            WebClient clientes = new WebClient();
            string json = clientes.DownloadString(webClient.BaseAddress);

            var jsonresult = JsonConvert.DeserializeObject<Periodos>(json.Replace("RetornaPeriodos(", "").Replace(")", ""));

            Console.ReadLine();

        }
        public Hoteis RetornaHoteis()
        {
            WebClient webClient = new WebClient();
            webClient.BaseAddress = @"https://4001.afpesp.org.br/RetornaHotel?callback=RetornaHotel&c=3&m=R1FGUVk5c0dtVmNhV3RCZ0phTTBDYk1IME1wSjU3a2lyMERZbjBVU1FIUU9YNFl3QTFhN1NnVmdHaW5PVUdtVmNzRGRFRk9JMWxXcGFpaTVVejlrRWlCR2pqUUgxb3hiUE8rUmdVVWF3OHF3NjgxMjkx&guid=5613adbd-ecd2-4b69-9240-aa8bb4447470&_=1569253941474";
            Uri uri = new Uri(webClient.BaseAddress);


            WebClient clientes = new WebClient();
            string json = clientes.DownloadString(webClient.BaseAddress);

            var jsonresult = JsonConvert.DeserializeObject<Hoteis>(json.Replace("RetornaHotel(", "").Replace(")", ""));

            Console.ReadLine();

            return jsonresult;
        }
    }


    public class Disponibilidade
    {
        public string codeReturn { get; set; }
        public string msg { get; set; }
        public string MaximoDias { get; set; }
    }



    public class Periodos
    {
        public string codeReturn { get; set; }
        public int din { get; set; }
        public int dout { get; set; }
        public int mesin { get; set; }
        public int mesout { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public Arrferiado[] ArrFeriados { get; set; }
        public Arrdisphotel[] arrDispHotel { get; set; }
        public Arrextra[] arrExtras { get; set; }
        public Arrhorario[] arrHorarios { get; set; }
    }

    public class Arrferiado
    {
        public string codigo { get; set; }
        public string inicio { get; set; }
        public string final { get; set; }
    }

    public class Arrdisphotel
    {
        public string cc { get; set; }
        public string mes { get; set; }
        public string ocupacao { get; set; }
    }

    public class Arrextra
    {
        public string id { get; set; }
        public string dsc { get; set; }
    }

    public class Arrhorario
    {
        public string _in { get; set; }
        public string _out { get; set; }
    }


    public class Hoteis
    {
        [JsonProperty(PropertyName = "codeReturn")]
        public string CodeReturn { get; set; }

        [JsonProperty(PropertyName = "arrRecords")]
        public List<ArrHoteis> ArrHoteis { get; set; }

        //RetornaHotel({ "codeReturn":"1", "arrRecords":[{"id":31206000, "dsc":"Caraguatatuba"}, {"id":31204000, "dsc":"Guarujá"}, {"id":31218000, "dsc":"Itanhaém"}, {"id":31220000, "dsc":"Maresias"}, {"id":31214000, "dsc":"Ubatuba"}]})
    }

    public class ArrHoteis
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "dsc")]
        public string Dsc { get; set; }
    }


}
