using System.Text.Json;
using EdFi.OdsApi.Sdk.Api.Resources;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
public class StudentResourcePayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";
    public override string? Content { get; set; }
    public string BasePath {get;set;}
    public string StudentUniqueId {get;set;}
    public async Task<StudentResourcePayloadContent> ExecuteAsync()
    {
        var api = new StudentsApi(BasePath);
        var response = await api.GetStudentsAsyncWithHttpInfo(studentUniqueId: StudentUniqueId);
        var students = response.Data;

        var dataContent = new StudentResourcePayloadContent()
        {
            Content = JsonSerializer.Serialize(students)
        };
        return dataContent;
    }
}
