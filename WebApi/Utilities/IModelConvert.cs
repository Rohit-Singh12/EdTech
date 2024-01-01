namespace WebApiProjectEdTech.Utilities
{
    /// <summary>
    ///     Convert One Model to another
    /// </summary>
    /// <typeparam name="TConverted"> Model to which the current Model is converted</typeparam>
    /// <typeparam name="TConvert"> Model to be converted to another model </typeparam>
    public interface IModelConvert<TConverted, TConvert>
    {
        TConverted ToModel();
    }
}