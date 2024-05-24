using System.Text.Json;
using System.Text.Json.Serialization;

namespace FrontendBlazorWebApp.Client.Models;

public class DynamicGraphQLResponse
{
    [JsonPropertyName("data")]
    public JsonElement Data { get; set; }
}
