namespace WebApiProjectEdTech.Utilities
{
    /// <summary>
    ///     Convert One Model to another
    /// </summary>
    /// <typeparam name="TConverted"> Model to which the current Model is converted</typeparam>
    public interface IModelConvert<TConverted>
    {
        TConverted ToModel();
    }
}