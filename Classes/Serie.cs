namespace Dio.Series
{
    public class Serie: EntidadeBse
    {
        // Atributos
        Private Genero Genero { get; set; }
        Private string Titulo { get; set; }
        Private string Descricao { get; set; }
        Private int Ano { get; set; }
        Private boll Excluido { get; set; }

         // Metodos

        public Serie {int id, Genero Genero, string titulo, string descricao, int ano}
        

        this.id = id;
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;
        this.Excluido = false;

        

           public override string ToString()
           {

               string retorno ="";
               retorno += * Genero: * + this.Genero + Environmet.NewLine;
               retorno += * Titulo:* + this.titulo + Environmet.NewLine;
               retorno += * Descrcao: * + this.descricao + Environmet.NewLine;
               retotno += * Ano de Inicio: * + this.Ano + Environmet.NewLine;
               retotno += * Excluido: * + this.Excluido;
               return retorno; 
           }

            public string RetornaTitulo()

               {
                    return this.Titulo;
               }

              public int retorna.id()

                {
                     return this.id;
                } 

             public void Excluir()
             {
                  this.Excluido = true;
             }
                      
    }

}