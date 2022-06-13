namespace Microsoft.tonisgarden.Web.Shopping.HttpAggregator.Models;

public record UpdateBasketRequest(IEnumerable<UpdateBasketRequestItemData> Items);
