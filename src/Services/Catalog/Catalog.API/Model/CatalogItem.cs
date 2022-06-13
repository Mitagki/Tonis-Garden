namespace Microsoft.tonisgarden.Services.Catalog.API.Model;

public class CatalogItem
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public decimal Price { get; private set; }

    public string PictureFileName { get; private set; }

    public int CatalogTypeId { get; private set; }

    public CatalogType CatalogType { get; private set; } = null!;

    public int CatalogSizeId { get; private set; }

    public CatalogSize CatalogSize { get; private set; } = null!;

    public int AvailableStock { get; private set; }

    public CatalogItem(
        int id,
        string name,
        decimal price,
        string pictureFileName,
        int catalogTypeId,
        int catalogSizeId,
        int availableStock) 
    {
        Id = id;
        Name = name;
        Price = price;
        PictureFileName = pictureFileName;
        CatalogTypeId = catalogTypeId;
        CatalogSizeId = catalogSizeId;
        AvailableStock = availableStock;
    }

    public int RemoveStock(int quantityDesired)
    {
        AvailableStock -= quantityDesired;

        return quantityDesired;
    }
}
