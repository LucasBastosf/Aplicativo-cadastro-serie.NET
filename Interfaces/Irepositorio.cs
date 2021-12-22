using System.Collections.Generic;

namespace Dio.Series.Interfaces
{
    public interface Irepositorio<t>
    {
      List<t> Lista ();

      T RetornaPorId (int id);

      void Insere (T entidade);

      void Exclui (ins id);

      void Atualiza (int id, T entidade);

      int ProximoId();
      
    }
}