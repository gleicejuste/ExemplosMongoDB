﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace ExemplosMongoDB
{
    public class ManipulandoDocumentos
    {

        static void Main(string[] args)
        {
            MainAsync();
        }

        Task T = MainAsync();

        static async Task MainAsync()
        {

            var doc = new BsonDocument
            {
                { "Titulo", "Guerra dos Tronos" }
            };

            doc.Add("Autor", "George R R Martin");
            doc.Add("Ano", 1999);
            doc.Add("Paginas", 856);

            var assuntoArray = new BsonArray();
            assuntoArray.Add("Fantasia");
            assuntoArray.Add("Ação");

            doc.Add("Assunto", assuntoArray);

            Console.WriteLine(doc);
            //await Task.Delay(10000);
        }
    }
}
