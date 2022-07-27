using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ExemplosMongoDB
{
    class Livro
    {

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public int Paginas { get; set; }
        public List<string> Assunto { get; set; }

        public Livro() { }

        public Livro(string titulo, string autor, int ano, int paginas, string assuntos)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Ano = ano;
            this.Paginas = paginas;

            string[] assuntosVetor = assuntos.Split(',');
            List<string> assuntosList = new List<string>();
            for (int i = 0; i <= assuntosVetor.Length - 1; i++)
            {
                assuntosList.Add(assuntosVetor[i].Trim());
            }

            this.Assunto = assuntosList;
        }
    }
 
}
