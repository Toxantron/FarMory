using Moryx.AbstractionLayer.Products;

namespace FarMory.Products
{
    public class CropInstance : ProductInstance<CropType>
    {
        public InstanceQuantity Quantity { get; set; }
    }

    public enum InstanceQuantity
    {
        Single,
        Multisown,
        Row,
        Batch
    }
}