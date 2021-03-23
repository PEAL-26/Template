using $safeprojectname$.Shared.Entidades;

namespace $safeprojectname$.Entidades
{
    public class Exemplo : Entidade
    {
        public Exemplo()
        {

        }

        public Exemplo(int id) : base(id)
        {

        }

        public override void Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
