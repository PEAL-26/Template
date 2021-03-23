using Template.Domain.Shared.Entidades;

namespace Template.Domain.Entidades
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
