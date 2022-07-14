using MongoDB.Driver;

namespace ExemplosMongoDB
{
    class ConexaoMongo
    {

        public const string STRING_CONEXAO = "mongodb://localhost:27017";
        public const string NOME_BASE = "Biblioteca";
        public const string NOME_COLECAO = "Livros";

        private static readonly IMongoClient _servidor;
        private static readonly IMongoDatabase _baseDados;

        static ConexaoMongo()
        { 
            _servidor = new MongoClient(STRING_CONEXAO);
            _baseDados = _servidor.GetDatabase(NOME_BASE);
        }

        public IMongoClient Servidor
        {
            get { return _servidor; }
        }

        public IMongoCollection<Livro> Livros
        {
            get { return _baseDados.GetCollection<Livro>(NOME_COLECAO); }
        }
    }
}
