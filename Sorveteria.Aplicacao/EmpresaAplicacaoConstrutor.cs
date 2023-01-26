using Sorveteria.RepositorioEF;

namespace Sorveteria.Aplicacao
{
    public class EmpresaAplicacaoConstrutor
    {   
        public static EmpresaAplicacao EmpresaAplicacaoEF()
        {
            return new EmpresaAplicacao(new EmpresaRepositorioEF());
        }
    }
}
