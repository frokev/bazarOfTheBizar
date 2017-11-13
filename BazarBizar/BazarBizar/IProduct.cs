namespace BazarBizar
{
    public interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
        string Key { get; }
        string Category { get; }

        Booth Booth { get; }
    }
}
