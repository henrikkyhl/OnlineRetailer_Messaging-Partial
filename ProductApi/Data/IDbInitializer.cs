namespace ProductApi.Data
{
    public interface IDbInitializer
    {
        void Initialize(ProductApiContext context);
    }
}
