namespace N_Gym.Entity.Objects
{
    public class ConvenioCliente
    {
        #region Propriedades
        public long Id { get; set; }
        public virtual Convenio Convenio { get; set; }
        public virtual Cliente Cliente { get; set; }
        #endregion

    }
}