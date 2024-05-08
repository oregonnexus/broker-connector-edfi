using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;
using System.Text.Json;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Competency Objectives")]
public class StudentCompetencyObjectivesJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCompetencyObjectivesJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        var config = await _tokenResolver.Resolve();
        
        var api = new StudentCompetencyObjectivesApi(config);
        var response = await api.GetStudentCompetencyObjectivesWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCompetencyObjectivesPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
