using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[DisplayName("Assessments")]
public class StudentAssessmentsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentAssessment",
        ObjectType = nameof(EdFiStudentAssessment),
        SchemaVersion = "3"
    };

    // private async Task<StudentAssessmentsPayloadContent> ExecuteAsync()
    // {
    //     var api = new StudentAssessmentsApi(BasePath);
    //     var response = await api.GetStudentAssessmentsWithHttpInfoAsync(studentUniqueId: StudentUniqueId);
    //     var assessments = response.Data;

    //     var dataContent = new StudentAssessmentsPayloadContent()
    //     {
    //         Content = JsonSerializer.Serialize(assessments)
    //     };
    //     return dataContent;
    // }
}
