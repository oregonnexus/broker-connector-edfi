using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi;

public class Student : IStudent
{
    [DataType(DataType.Text)]
    [Description("Student ID in the Ed-Fi ODS database.")]
    [Required]
    public required int Id { get; set; }

    [DataType(DataType.Text)]
    [Description("Student USI in the Ed-Fi ODS database.")]
    public int? StudentUsi { get; set; }

    [DataType(DataType.Text)]
    [Description("Student Unique ID, usually specified from ODS data source.")]
    [Required]
    public required string StudentUniqueId { get; set; }

    [DataType(DataType.Date)]
    [Description("The date of birth of the student.")]
    [Required]
    public required string BirthDate { get; set; }

    [DataType(DataType.Text)]
    [Description("The gender at birth for the student.")]
    public string? BirthSexDescriptor { get; set; }

    [DataType(DataType.Text)]
    [Description("The first name of the student.")]
    [Required]
    public required string FirstName { get; set; }

    [DataType(DataType.Text)]
    [Description("The appendage denoting the student's generation in the family (e.g., Jr., Sr., III).")]
    public string? GenerationCodeSuffix { get; set; }

    [DataType(DataType.Text)]
    [Description("The last surname of the student.")]
    [Required]
    public required string LastSurname { get; set; }

    [DataType(DataType.Text)]
    [Description("The maiden name of the student.")]
    public string? MaidenName { get; set; }

    [DataType(DataType.Text)]
    [Description("The middle name of the student.")]
    public string? MiddleName { get; set; }
}
