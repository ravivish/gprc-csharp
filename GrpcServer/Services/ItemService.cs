using Grpc.Core;
using GrpcApp;

namespace GrpcServer.Services;

public class ItemServiceImpl : ItemService.ItemServiceBase
{
    public override Task<ItemResponse> GetItem(ItemRequest request, ServerCallContext context)
    {
        // Just a simple hardcoded response for demonstration
        var response = new ItemResponse
        {
            ItemName = "Example Item",
            ItemPrice = 25.99
        };
        return Task.FromResult(response);
    }
}