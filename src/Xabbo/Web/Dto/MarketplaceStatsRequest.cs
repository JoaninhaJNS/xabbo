using System.Text.Json.Serialization;

namespace Xabbo.Web.Dto;

public sealed class MarketplaceStatsRequest
{
    [JsonPropertyName("roomItems")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<MarketplaceStatsRequestItem>? RoomItems { get; set; }

    [JsonPropertyName("wallItems")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<MarketplaceStatsRequestItem>? WallItems { get; set; }
}

public sealed class MarketplaceStatsRequestItem
{
    [JsonPropertyName("item")]
    public string Item { get; set; } = "";
}
