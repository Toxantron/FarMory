using Moryx.AbstractionLayer.Products;

namespace FarMory.Products
{
    public class AnimalType : ProductType
    {
        protected override ProductInstance Instantiate()
        {
            return new AnimalInstance();
        }
    }
}