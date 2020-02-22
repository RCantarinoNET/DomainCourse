namespace Course.Domain.Entities
{
    public class Subsidiaria : Base.EntityBase
    {
        public Subsidiaria(string nome)
        {
            this.Name = nome;
        }

        public string Name { get; private  set; }
    }
}