﻿using RogueForumMetierPortable;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RogueForumConsumeWSR
{
    public static class ConsumeWSR
    {
        private const string ADR_GET_RUBRIQUES = "http://user09.2isa.org/RESTService.svc/Rubriques";
        private static List<Rubrique> _rubriques = new List<Rubrique>();

        public static List<Rubrique> Rubriques
        {
            get
            {
                return _rubriques;
            }
        }

        public static async Task<List<Rubrique>> getRubriques()
        {
           
                // Création de l'instance HttpClient avec Timeout infini car c'est le CancellationToken qui gère l'arrêt ou le TimeOut de la tâche
                // ATTENTION, en Windows phone on a quand même un timeout au bout de 60s
                using (HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite) })
                {
                    // Permet de supprimer la mise en cache. En WindowsPhone, deux requêtes successives identiques retournent le résultat de la première 
                    // qui a été mis en cache
                    client.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;
                                       
                        // Appel du service Rest (en asynchrone)
                        using (HttpResponseMessage wcfResponse = await client.GetAsync(ADR_GET_RUBRIQUES, CancellationToken.None))
                        {
                            if (wcfResponse.IsSuccessStatusCode)
                            {
                                // Désérialisation de la réponse du service
                                return DeserializeHttpContent(wcfResponse.Content);
                            }
                           
                        }
                return null;
                }
            }



        private static List<Rubrique> DeserializeHttpContent(HttpContent content)
        {
            using (Stream s = content.ReadAsStreamAsync().Result)
            {
                if (s.Length > 0)
                {
                   return _rubriques = (List<Rubrique>)new DataContractSerializer(typeof(List<Rubrique>)).ReadObject(s);
                }
                return null;
            }
        }


    }
}