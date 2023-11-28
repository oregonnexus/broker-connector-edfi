using System.Text.Json;
using EdFi.OdsApi.Sdk.Api.Resources;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
public class GradesPayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";
    public override string? Content { get; set; }
    public string BasePath {get;set;}
    public string StudentUniqueId {get;set;}

    private async Task<GradesPayloadContent> ExecuteAsync()
    {
        var api = new GradesApi(BasePath);
        var response = await api.GetGradesAsyncWithHttpInfo(studentUniqueId: StudentUniqueId);
        var grades = response.Data;

        var dataContent = new GradesPayloadContent()
        {
            Content = JsonSerializer.Serialize(grades)
        };
        return dataContent;
    }
}
