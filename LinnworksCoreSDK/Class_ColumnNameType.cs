using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
//ReSharper disable UnusedMember.Global
namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ColumnNameType
    {
        SKU,
        Title,
        VariationGroupName,
        RetailPrice,
        PurchasePrice,
        Tracked,
        Barcode,
        Available,
        MinimumLevel,
        InOrder,
        StockLevel,
        StockValue,
        Due,
        BinRack,
        Category,
        Image,
        CreatedDate,
        ModifiedDate,
    }
}