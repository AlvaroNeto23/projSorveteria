using Sorveteria.RepositorioEF;

namespace Sorveteria.Aplicacao
{
    public class UsuarioAplicacaoConstrutor
    {
        public static UsuarioAplicacao UsuarioAplicacaoEF()
        {
            return new UsuarioAplicacao(new UsuarioRepositorioEF());
        }
    }
}
