/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Resources
{
    /// <summary>
    /// EdFiStudentEducationOrganizationAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociation :  IEquatable<EdFiStudentEducationOrganizationAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="addresses">An unordered collection of studentEducationOrganizationAssociationAddresses. The set of elements that describes an address, including the street address, city, state, and ZIP code..</param>
        /// <param name="cohortYears">An unordered collection of studentEducationOrganizationAssociationCohortYears. The type and year of a cohort (e.g., 9th grade) the student belongs to as determined by the year that student entered a specific grade..</param>
        /// <param name="disabilities">An unordered collection of studentEducationOrganizationAssociationDisabilities. The disability condition(s) that best describes an individual&#39;s impairment, as determined by evaluation(s) conducted by the education organization..</param>
        /// <param name="electronicMails">An unordered collection of studentEducationOrganizationAssociationElectronicMails. The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the individual or organization belongs..</param>
        /// <param name="hispanicLatinoEthnicity">An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot;.</param>
        /// <param name="internationalAddresses">An unordered collection of studentEducationOrganizationAssociationInternationalAddresses. The set of elements that describes an international address..</param>
        /// <param name="languages">An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes..</param>
        /// <param name="limitedEnglishProficiencyDescriptor">An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient..</param>
        /// <param name="loginId">The login ID for the user; used for security access control interface..</param>
        /// <param name="oldEthnicityDescriptor">Previous definition of Ethnicity combining Hispanic/Latino and race:          1 - American Indian or Alaskan Native          2 - Asian or Pacific Islander          3 - Black, not of Hispanic origin          4 - Hispanic          5 - White, not of Hispanic origin..</param>
        /// <param name="profileThumbnail">Locator reference for the student photo. The specification for that reference is left to local definition..</param>
        /// <param name="programParticipations">An unordered collection of studentEducationOrganizationAssociationProgramParticipations. Key programs the student is participating in or receives services from..</param>
        /// <param name="races">An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies as last reported to the education organization. The data model allows for multiple entries so that each individual can specify all appropriate races..</param>
        /// <param name="sexDescriptor">The student&#39;s gender as last reported to the education organization. (required).</param>
        /// <param name="studentCharacteristics">An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of the student&#39;s home situation:          Displaced Homemaker, Immigrant, Migratory, Military Parent, Pregnant Teen, Single Parent, and Unaccompanied Youth..</param>
        /// <param name="studentIdentificationCodes">An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student..</param>
        /// <param name="studentIndicators">An unordered collection of studentEducationOrganizationAssociationStudentIndicators. Indicator(s) or metric(s) computed for the student (e.g., at risk) to influence more effective education or direct specific interventions..</param>
        /// <param name="telephones">An unordered collection of studentEducationOrganizationAssociationTelephones. The 10-digit telephone number, including the area code, for the person..</param>
        /// <param name="tribalAffiliations">An unordered collection of studentEducationOrganizationAssociationTribalAffiliations. An American Indian tribe with which the student is affiliated as last reported to the education organization..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentEducationOrganizationAssociation(string id = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiStudentReference studentReference = default(EdFiStudentReference), List<EdFiStudentEducationOrganizationAssociationAddress> addresses = default(List<EdFiStudentEducationOrganizationAssociationAddress>), List<EdFiStudentEducationOrganizationAssociationCohortYear> cohortYears = default(List<EdFiStudentEducationOrganizationAssociationCohortYear>), List<EdFiStudentEducationOrganizationAssociationDisability> disabilities = default(List<EdFiStudentEducationOrganizationAssociationDisability>), List<EdFiStudentEducationOrganizationAssociationElectronicMail> electronicMails = default(List<EdFiStudentEducationOrganizationAssociationElectronicMail>), bool? hispanicLatinoEthnicity = default(bool?), List<EdFiStudentEducationOrganizationAssociationInternationalAddress> internationalAddresses = default(List<EdFiStudentEducationOrganizationAssociationInternationalAddress>), List<EdFiStudentEducationOrganizationAssociationLanguage> languages = default(List<EdFiStudentEducationOrganizationAssociationLanguage>), string limitedEnglishProficiencyDescriptor = default(string), string loginId = default(string), string oldEthnicityDescriptor = default(string), string profileThumbnail = default(string), List<EdFiStudentEducationOrganizationAssociationProgramParticipation> programParticipations = default(List<EdFiStudentEducationOrganizationAssociationProgramParticipation>), List<EdFiStudentEducationOrganizationAssociationRace> races = default(List<EdFiStudentEducationOrganizationAssociationRace>), string sexDescriptor = default(string), List<EdFiStudentEducationOrganizationAssociationStudentCharacteristic> studentCharacteristics = default(List<EdFiStudentEducationOrganizationAssociationStudentCharacteristic>), List<EdFiStudentEducationOrganizationAssociationStudentIdentificationCode> studentIdentificationCodes = default(List<EdFiStudentEducationOrganizationAssociationStudentIdentificationCode>), List<EdFiStudentEducationOrganizationAssociationStudentIndicator> studentIndicators = default(List<EdFiStudentEducationOrganizationAssociationStudentIndicator>), List<EdFiStudentEducationOrganizationAssociationTelephone> telephones = default(List<EdFiStudentEducationOrganizationAssociationTelephone>), List<EdFiStudentEducationOrganizationAssociationTribalAffiliation> tribalAffiliations = default(List<EdFiStudentEducationOrganizationAssociationTribalAffiliation>), string etag = default(string))
        {
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiStudentEducationOrganizationAssociation and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentEducationOrganizationAssociation and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            // to ensure "sexDescriptor" is required (not null)
            if (sexDescriptor == null)
            {
                throw new InvalidDataException("sexDescriptor is a required property for EdFiStudentEducationOrganizationAssociation and cannot be null");
            }
            else
            {
                this.SexDescriptor = sexDescriptor;
            }
            this.Id = id;
            this.Addresses = addresses;
            this.CohortYears = cohortYears;
            this.Disabilities = disabilities;
            this.ElectronicMails = electronicMails;
            this.HispanicLatinoEthnicity = hispanicLatinoEthnicity;
            this.InternationalAddresses = internationalAddresses;
            this.Languages = languages;
            this.LimitedEnglishProficiencyDescriptor = limitedEnglishProficiencyDescriptor;
            this.LoginId = loginId;
            this.OldEthnicityDescriptor = oldEthnicityDescriptor;
            this.ProfileThumbnail = profileThumbnail;
            this.ProgramParticipations = programParticipations;
            this.Races = races;
            this.StudentCharacteristics = studentCharacteristics;
            this.StudentIdentificationCodes = studentIdentificationCodes;
            this.StudentIndicators = studentIndicators;
            this.Telephones = telephones;
            this.TribalAffiliations = tribalAffiliations;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationAddresses. The set of elements that describes an address, including the street address, city, state, and ZIP code.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationAddresses. The set of elements that describes an address, including the street address, city, state, and ZIP code.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationAddress> Addresses { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationCohortYears. The type and year of a cohort (e.g., 9th grade) the student belongs to as determined by the year that student entered a specific grade.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationCohortYears. The type and year of a cohort (e.g., 9th grade) the student belongs to as determined by the year that student entered a specific grade.</value>
        [DataMember(Name="cohortYears", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationCohortYear> CohortYears { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationDisabilities. The disability condition(s) that best describes an individual&#39;s impairment, as determined by evaluation(s) conducted by the education organization.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationDisabilities. The disability condition(s) that best describes an individual&#39;s impairment, as determined by evaluation(s) conducted by the education organization.</value>
        [DataMember(Name="disabilities", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationDisability> Disabilities { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationElectronicMails. The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the individual or organization belongs.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationElectronicMails. The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the individual or organization belongs.</value>
        [DataMember(Name="electronicMails", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationElectronicMail> ElectronicMails { get; set; }

        /// <summary>
        /// An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot;
        /// </summary>
        /// <value>An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot;</value>
        [DataMember(Name="hispanicLatinoEthnicity", EmitDefaultValue=false)]
        public bool? HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationInternationalAddresses. The set of elements that describes an international address.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationInternationalAddresses. The set of elements that describes an international address.</value>
        [DataMember(Name="internationalAddresses", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationInternationalAddress> InternationalAddresses { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes.</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationLanguage> Languages { get; set; }

        /// <summary>
        /// An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient.
        /// </summary>
        /// <value>An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient.</value>
        [DataMember(Name="limitedEnglishProficiencyDescriptor", EmitDefaultValue=false)]
        public string LimitedEnglishProficiencyDescriptor { get; set; }

        /// <summary>
        /// The login ID for the user; used for security access control interface.
        /// </summary>
        /// <value>The login ID for the user; used for security access control interface.</value>
        [DataMember(Name="loginId", EmitDefaultValue=false)]
        public string LoginId { get; set; }

        /// <summary>
        /// Previous definition of Ethnicity combining Hispanic/Latino and race:          1 - American Indian or Alaskan Native          2 - Asian or Pacific Islander          3 - Black, not of Hispanic origin          4 - Hispanic          5 - White, not of Hispanic origin.
        /// </summary>
        /// <value>Previous definition of Ethnicity combining Hispanic/Latino and race:          1 - American Indian or Alaskan Native          2 - Asian or Pacific Islander          3 - Black, not of Hispanic origin          4 - Hispanic          5 - White, not of Hispanic origin.</value>
        [DataMember(Name="oldEthnicityDescriptor", EmitDefaultValue=false)]
        public string OldEthnicityDescriptor { get; set; }

        /// <summary>
        /// Locator reference for the student photo. The specification for that reference is left to local definition.
        /// </summary>
        /// <value>Locator reference for the student photo. The specification for that reference is left to local definition.</value>
        [DataMember(Name="profileThumbnail", EmitDefaultValue=false)]
        public string ProfileThumbnail { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationProgramParticipations. Key programs the student is participating in or receives services from.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationProgramParticipations. Key programs the student is participating in or receives services from.</value>
        [DataMember(Name="programParticipations", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationProgramParticipation> ProgramParticipations { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies as last reported to the education organization. The data model allows for multiple entries so that each individual can specify all appropriate races.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies as last reported to the education organization. The data model allows for multiple entries so that each individual can specify all appropriate races.</value>
        [DataMember(Name="races", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationRace> Races { get; set; }

        /// <summary>
        /// The student&#39;s gender as last reported to the education organization.
        /// </summary>
        /// <value>The student&#39;s gender as last reported to the education organization.</value>
        [DataMember(Name="sexDescriptor", EmitDefaultValue=false)]
        public string SexDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of the student&#39;s home situation:          Displaced Homemaker, Immigrant, Migratory, Military Parent, Pregnant Teen, Single Parent, and Unaccompanied Youth.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of the student&#39;s home situation:          Displaced Homemaker, Immigrant, Migratory, Military Parent, Pregnant Teen, Single Parent, and Unaccompanied Youth.</value>
        [DataMember(Name="studentCharacteristics", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentCharacteristic> StudentCharacteristics { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.</value>
        [DataMember(Name="studentIdentificationCodes", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentIdentificationCode> StudentIdentificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentIndicators. Indicator(s) or metric(s) computed for the student (e.g., at risk) to influence more effective education or direct specific interventions.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentIndicators. Indicator(s) or metric(s) computed for the student (e.g., at risk) to influence more effective education or direct specific interventions.</value>
        [DataMember(Name="studentIndicators", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentIndicator> StudentIndicators { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationTelephones. The 10-digit telephone number, including the area code, for the person.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationTelephones. The 10-digit telephone number, including the area code, for the person.</value>
        [DataMember(Name="telephones", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationTelephone> Telephones { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationTribalAffiliations. An American Indian tribe with which the student is affiliated as last reported to the education organization.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationTribalAffiliations. An American Indian tribe with which the student is affiliated as last reported to the education organization.</value>
        [DataMember(Name="tribalAffiliations", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationTribalAffiliation> TribalAffiliations { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  CohortYears: ").Append(CohortYears).Append("\n");
            sb.Append("  Disabilities: ").Append(Disabilities).Append("\n");
            sb.Append("  ElectronicMails: ").Append(ElectronicMails).Append("\n");
            sb.Append("  HispanicLatinoEthnicity: ").Append(HispanicLatinoEthnicity).Append("\n");
            sb.Append("  InternationalAddresses: ").Append(InternationalAddresses).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  LimitedEnglishProficiencyDescriptor: ").Append(LimitedEnglishProficiencyDescriptor).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  OldEthnicityDescriptor: ").Append(OldEthnicityDescriptor).Append("\n");
            sb.Append("  ProfileThumbnail: ").Append(ProfileThumbnail).Append("\n");
            sb.Append("  ProgramParticipations: ").Append(ProgramParticipations).Append("\n");
            sb.Append("  Races: ").Append(Races).Append("\n");
            sb.Append("  SexDescriptor: ").Append(SexDescriptor).Append("\n");
            sb.Append("  StudentCharacteristics: ").Append(StudentCharacteristics).Append("\n");
            sb.Append("  StudentIdentificationCodes: ").Append(StudentIdentificationCodes).Append("\n");
            sb.Append("  StudentIndicators: ").Append(StudentIndicators).Append("\n");
            sb.Append("  Telephones: ").Append(Telephones).Append("\n");
            sb.Append("  TribalAffiliations: ").Append(TribalAffiliations).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiStudentEducationOrganizationAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.CohortYears == input.CohortYears ||
                    this.CohortYears != null &&
                    this.CohortYears.SequenceEqual(input.CohortYears)
                ) && 
                (
                    this.Disabilities == input.Disabilities ||
                    this.Disabilities != null &&
                    this.Disabilities.SequenceEqual(input.Disabilities)
                ) && 
                (
                    this.ElectronicMails == input.ElectronicMails ||
                    this.ElectronicMails != null &&
                    this.ElectronicMails.SequenceEqual(input.ElectronicMails)
                ) && 
                (
                    this.HispanicLatinoEthnicity == input.HispanicLatinoEthnicity ||
                    (this.HispanicLatinoEthnicity != null &&
                    this.HispanicLatinoEthnicity.Equals(input.HispanicLatinoEthnicity))
                ) && 
                (
                    this.InternationalAddresses == input.InternationalAddresses ||
                    this.InternationalAddresses != null &&
                    this.InternationalAddresses.SequenceEqual(input.InternationalAddresses)
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.LimitedEnglishProficiencyDescriptor == input.LimitedEnglishProficiencyDescriptor ||
                    (this.LimitedEnglishProficiencyDescriptor != null &&
                    this.LimitedEnglishProficiencyDescriptor.Equals(input.LimitedEnglishProficiencyDescriptor))
                ) && 
                (
                    this.LoginId == input.LoginId ||
                    (this.LoginId != null &&
                    this.LoginId.Equals(input.LoginId))
                ) && 
                (
                    this.OldEthnicityDescriptor == input.OldEthnicityDescriptor ||
                    (this.OldEthnicityDescriptor != null &&
                    this.OldEthnicityDescriptor.Equals(input.OldEthnicityDescriptor))
                ) && 
                (
                    this.ProfileThumbnail == input.ProfileThumbnail ||
                    (this.ProfileThumbnail != null &&
                    this.ProfileThumbnail.Equals(input.ProfileThumbnail))
                ) && 
                (
                    this.ProgramParticipations == input.ProgramParticipations ||
                    this.ProgramParticipations != null &&
                    this.ProgramParticipations.SequenceEqual(input.ProgramParticipations)
                ) && 
                (
                    this.Races == input.Races ||
                    this.Races != null &&
                    this.Races.SequenceEqual(input.Races)
                ) && 
                (
                    this.SexDescriptor == input.SexDescriptor ||
                    (this.SexDescriptor != null &&
                    this.SexDescriptor.Equals(input.SexDescriptor))
                ) && 
                (
                    this.StudentCharacteristics == input.StudentCharacteristics ||
                    this.StudentCharacteristics != null &&
                    this.StudentCharacteristics.SequenceEqual(input.StudentCharacteristics)
                ) && 
                (
                    this.StudentIdentificationCodes == input.StudentIdentificationCodes ||
                    this.StudentIdentificationCodes != null &&
                    this.StudentIdentificationCodes.SequenceEqual(input.StudentIdentificationCodes)
                ) && 
                (
                    this.StudentIndicators == input.StudentIndicators ||
                    this.StudentIndicators != null &&
                    this.StudentIndicators.SequenceEqual(input.StudentIndicators)
                ) && 
                (
                    this.Telephones == input.Telephones ||
                    this.Telephones != null &&
                    this.Telephones.SequenceEqual(input.Telephones)
                ) && 
                (
                    this.TribalAffiliations == input.TribalAffiliations ||
                    this.TribalAffiliations != null &&
                    this.TribalAffiliations.SequenceEqual(input.TribalAffiliations)
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.CohortYears != null)
                    hashCode = hashCode * 59 + this.CohortYears.GetHashCode();
                if (this.Disabilities != null)
                    hashCode = hashCode * 59 + this.Disabilities.GetHashCode();
                if (this.ElectronicMails != null)
                    hashCode = hashCode * 59 + this.ElectronicMails.GetHashCode();
                if (this.HispanicLatinoEthnicity != null)
                    hashCode = hashCode * 59 + this.HispanicLatinoEthnicity.GetHashCode();
                if (this.InternationalAddresses != null)
                    hashCode = hashCode * 59 + this.InternationalAddresses.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.LimitedEnglishProficiencyDescriptor != null)
                    hashCode = hashCode * 59 + this.LimitedEnglishProficiencyDescriptor.GetHashCode();
                if (this.LoginId != null)
                    hashCode = hashCode * 59 + this.LoginId.GetHashCode();
                if (this.OldEthnicityDescriptor != null)
                    hashCode = hashCode * 59 + this.OldEthnicityDescriptor.GetHashCode();
                if (this.ProfileThumbnail != null)
                    hashCode = hashCode * 59 + this.ProfileThumbnail.GetHashCode();
                if (this.ProgramParticipations != null)
                    hashCode = hashCode * 59 + this.ProgramParticipations.GetHashCode();
                if (this.Races != null)
                    hashCode = hashCode * 59 + this.Races.GetHashCode();
                if (this.SexDescriptor != null)
                    hashCode = hashCode * 59 + this.SexDescriptor.GetHashCode();
                if (this.StudentCharacteristics != null)
                    hashCode = hashCode * 59 + this.StudentCharacteristics.GetHashCode();
                if (this.StudentIdentificationCodes != null)
                    hashCode = hashCode * 59 + this.StudentIdentificationCodes.GetHashCode();
                if (this.StudentIndicators != null)
                    hashCode = hashCode * 59 + this.StudentIndicators.GetHashCode();
                if (this.Telephones != null)
                    hashCode = hashCode * 59 + this.Telephones.GetHashCode();
                if (this.TribalAffiliations != null)
                    hashCode = hashCode * 59 + this.TribalAffiliations.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
