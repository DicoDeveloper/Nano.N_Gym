namespace Nano.N_Base.Model.Interface
{
    public enum AutofacInstanceContextMode : int
    {
        PerCall = 0,
        PerHttpRequest = 1,
        PerLifetimeScope = 2,
    }
}
