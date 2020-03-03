namespace OrderApi.Data
{
    public interface IDbInitializer
    {
        void Initialize(OrderApiContext context);
    }
}
