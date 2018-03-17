namespace N_Gym.Entity.Objects
{
    public class ConvenioCliente
    {
        #region Propriedades
        public long ConvenioId { get; set; }
        public long ClienteId { get; set; }
        public virtual Convenio Convenio { get; set; }
        public virtual Cliente Cliente { get; set; }
        #endregion

    }
}