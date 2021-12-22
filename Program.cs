using System;

namespace DiO.Series
{
    class program
    {
        static void Main(string[] args)
        {
            string OpcaoUsuario = ObterOpcaoUsuario();

            while (OpcaoUsuario)
            {
                 Case "1":
                   listaSerie();
                   break;
                Case "2":
                   InserirSerie();
                   break;
                Case "3":
                   AtualizarSerie();
                   break;
                Case "4":
                   //EcluirSerie();
                   break;
                Case "5":
                   //VisualizarSerie();
                   break;
                 Case "c":
                   //ConsoleClear();
                   break;
                Case "x":
                   //Sair();
                   break;
            }
            
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

            console.while ("Digite o id da série");
            {
                int indiceSerie =  int.Parse(consile.WriteLine());
            

        Private static void listaSerie()
        {
            Console.WriteLine("Lista séries");

            var Lista = repositorio.Lista();

            if (lista.count == 0)
            {
                console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                console.WriteLine(#ID {0}: . {1}* , serie.retornaid(). , serie.retotrnatitulo());
            }

        }

         private static void InserirSerie()
        {
             console.WriteLine("Inserir série");
             //
             //
             foreach (int i in enum.GetValues(typeof(Genero)))
             {
                 console.WriteLine(*{0}.{1}* , i, Enum.GetName(typeof(Genero). 1));
             }
             Console.Write("Digite o genero entre as opcoes a cima: ");
             int entradaGenero = int.Perse(console.ReadLine());

            Console.Write("Digite o titulo da serie: ");
             int entradaTitulo = int.Perse(console.ReadLine();

             Console.Write("Digite o ano de inicio da serie: ");
             int entraAno = int.Perse(console.ReadLine();

             Serie novaserie = new Serie(id: Repositorio.ProximoId().)
                                                        Genero: (Genero)entradaGenero,
                                                        Titulo: entradaTitulo,
                                                        Ano: entradaAno,
                                                        descricao: entradaDescricao;

             repositorio.Insere(novaserie);                                          
                                                
        }
            
        Private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Dio Serie ao seu dispor!!!");
            System.Console.WriteLine("Informe a opcaso desejada");

            System.Console.WriteLine("1- Lista Serie");
            System.Console.WriteLine("2- Inserir nova serie");
            System.Console.WriteLine("3- Atualizar Serie");
            System.Console.WriteLine("4- Excluir Serie");
            System.Console.WriteLine("5- Visualizar Serie");
            System.Console.WriteLine("C- Limpar Tela");
            System.Console.WriteLine("x- Sair");

            string ObterOpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return ObterOpcaoUsuario;
        }
    }
}