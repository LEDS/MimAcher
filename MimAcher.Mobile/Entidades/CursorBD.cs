using System.Collections.Generic;

namespace MimAcher.Mobile.Entidades
{
    public static class CursorBd
    {
        //Set attributes to connect to database
        //private static string url = "http://ghoststation.ddns.net:8091/";

        //Set functions to read and write stuff to database
        public static void Write(Participante a)
        {
            /*
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("url" + "Participante");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            */
        }

        public static Dictionary<string, List<Participante>> Match(Participante a)
        {
            var matchs = new Dictionary<string, List<Participante>>
            {
                ["gostos"] = new List<Participante>(),
                ["interesses"] = new List<Participante>(),
                ["competencias"] = new List<Participante>()
            };


            //TODO: buscar os matchs no banco

            return matchs;
        }

/*
        public static Participante GetParticipante(string email)
        {
            Participante participante = null;
            //TODO
            return participante;
        }
*/
        
    }
}