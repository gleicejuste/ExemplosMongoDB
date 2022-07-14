using MongoDB.Bson;
using MongoDB.Driver;

namespace ExemplosMongoDB
{
    public class AcessoMongoDB
    {

        static void Main(string[] args)
        {
            //Task T = AcessoComJson();
            Task T = AcessoComOrientacaoObjeto();
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }


        static async Task AcessoComJson()
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

            //acesso ao servidor do MongoDB
            string stringConexao = "mongodb://localhost:27017";
            IMongoClient servidor = new MongoClient(stringConexao);

            //acesso ao banco de dados
            IMongoDatabase bancoDados = servidor.GetDatabase("Biblioteca");

            //acesso a coleção
            IMongoCollection<BsonDocument> colecao = bancoDados.GetCollection<BsonDocument>("Livros");

            //incluindo documento
            await colecao.InsertOneAsync(doc);

            Console.WriteLine("Documento Incluído");

        }

        static async Task AcessoComOrientacaoObjeto()
        {

            Livro livro = new Livro();
            livro.Titulo = "Sob a Redoma";
            livro.Autor = "Stepahn King";
            livro.Paginas = 679;
            livro.Ano = 2012;

            List<string>assuntos = new List<string>();
            assuntos.Add("Ficação Científica");
            assuntos.Add("Terror");
            assuntos.Add("Ação");

            livro.Assunto = assuntos;


            //acesso ao servidor do MongoDB
            string stringConexao = "mongodb://localhost:27017";
            IMongoClient servidor = new MongoClient(stringConexao);

            //acesso ao banco de dados
            IMongoDatabase bancoDados = servidor.GetDatabase("Biblioteca");

            //acesso a coleção
            IMongoCollection<Livro> colecao = bancoDados.GetCollection<Livro>("Livros");


            //incluindo documento
            await colecao.InsertOneAsync(livro);

            Console.WriteLine("Documento Incluído");

        }

    }
}
