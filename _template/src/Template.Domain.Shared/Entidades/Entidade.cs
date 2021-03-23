using Flunt.Notifications;

namespace $safeprojectname$.Entidades
{
    public abstract class Entidade: Notifiable<Notification>
    {
        public int Id { get; private set; }
        public abstract void Validar();

        protected Entidade()
        {
        }

        protected Entidade(int id)
        {
            Id = id;
        }

    }
}
