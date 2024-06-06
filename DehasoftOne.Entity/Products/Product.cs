using DehasoftOne.Entity.BaseEntities;
using DehasoftOne.Entity.Enums;

namespace DehasoftOne.Entity.Products;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public string Barcode { get; set; }
    public Unit Unit { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}
