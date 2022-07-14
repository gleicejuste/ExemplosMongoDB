
namespace ExemplosMongoDB
{
    class AcessoMongoClasseExterna
    {

        static void Main(string[] args)
        {
            InserindoUmLivroPorVez();
           // Task T = InserindoMuitosLivrosPorVez();
            Console.WriteLine("...");
            Console.ReadLine();
        }

        static async Task InserindoUmLivroPorVez()
        {

            await new ConexaoMongo().Livros.InsertOneAsync(
                new Livro("Dom Casmurro", "Machado de Assis", 1923, 188, "Romance, Literatura Brasileira"));
            await new ConexaoMongo().Livros.InsertOneAsync(
                new Livro("A Arte da Ficção", "David Lodge", 2002, 230, "Didática, Auto Ajuda"));

            Console.WriteLine("Documento Incluído");

        }

        static async Task InserindoMuitosLivrosPorVez()
        {

            List<Livro> livros = new List<Livro>();
            livros.Add(new Livro("A Dança com os Dragões", "George R R Martin", 2011, 934, "Fantasia, Ação"));
            livros.Add(new Livro("A Tormenta das Espadas", "George R R Martin", 2006, 1276, "Fantasia, Ação"));
            livros.Add(new Livro("Memórias Póstumas de Brás Cubas", "Machado de Assis", 1915, 267, "Literatura Brasileira"));
            livros.Add(new Livro("Star Trek Portal do Tempo", "Crispin A C", 2002, 321, "Fantasia, Ação"));
            livros.Add(new Livro("Star Trek Enigmas", "Dedopolus Tim", 2006, 195, "Ficção Científica, Ação"));
            livros.Add(new Livro("Emília no Pais da Gramática", "Monteiro Lobato", 1936, 230, "Infantil, Literatura Brasileira, Didático"));
            livros.Add(new Livro("Chapelzinho Amarelo", "Chico Buarque", 2008, 123, "Infantil, Literatura Brasileira"));
            livros.Add(new Livro("20000 Léguas Submarinas", "Julio Verne", 1894, 256, "Ficção Científica, Ação"));
            livros.Add(new Livro("Primeiros Passos na Matemática", "Mantin Ibanez", 2014, 190, "Didático, Infantil"));
            livros.Add(new Livro("Saúde e Sabor", "Yeomans Matthew", 2012, 245, "Culinária, Didático"));
            livros.Add(new Livro("Goldfinger", "Iam Fleming", 1956, 267, "Espionagem, Ação"));
            livros.Add(new Livro("Da Rússia com Amor", "Iam Fleming", 1966, 245, "Espionagem, Ação"));
            livros.Add(new Livro("O Senhor dos Aneis", "J R R Token", 1948, 1956, "Fantasia, Ação"));

            await new ConexaoMongo().Livros.InsertManyAsync(livros);
                        
            Console.WriteLine("Documento Incluído");

        }
    }
}
