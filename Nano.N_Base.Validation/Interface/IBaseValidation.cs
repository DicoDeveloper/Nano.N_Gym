namespace Nano.N_Base.Validation.Interface
{
    public interface IBaseValidation<TEntity> where TEntity : class
    {
        void Validate(TEntity entity);
        void ValidateId(long id);
        void ValidateEntityToDelete(TEntity entity);
    }
}
