namespace N_Gym.Entity.Objects
{
    public class ConvenioCliente
    {
        public long Id { get; set; }
        public virtual Convenio Convenio { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}