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
    /// EdFiSchool
    /// </summary>
    [DataContract]
    public partial class EdFiSchool :  IEquatable<EdFiSchool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchool" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSchool() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchool" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationCategories">An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. (required).</param>
        /// <param name="gradeLevels">An unordered collection of schoolGradeLevels. The grade levels served at the school. (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="charterApprovalSchoolYearTypeReference">charterApprovalSchoolYearTypeReference.</param>
        /// <param name="localEducationAgencyReference">localEducationAgencyReference.</param>
        /// <param name="addresses">An unordered collection of educationOrganizationAddresses. The set of elements that describes the physical location of the education entity, including the street address, city, state, ZIP code, and ZIP code + 4..</param>
        /// <param name="administrativeFundingControlDescriptor">The type of education institution as classified by its funding source, for example public or private..</param>
        /// <param name="charterApprovalAgencyTypeDescriptor">The type of agency that approved the establishment or continuation of a charter school..</param>
        /// <param name="charterStatusDescriptor">A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school..</param>
        /// <param name="identificationCodes">An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity..</param>
        /// <param name="indicators">An unordered collection of educationOrganizationIndicators. An indicator or metric of an Education Organization..</param>
        /// <param name="institutionTelephones">An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity..</param>
        /// <param name="internationalAddresses">An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity..</param>
        /// <param name="internetAccessDescriptor">The type of Internet access available..</param>
        /// <param name="magnetSpecialProgramEmphasisSchoolDescriptor">A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2) to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, or foreign language)..</param>
        /// <param name="nameOfInstitution">The full, legally accepted name of the institution. (required).</param>
        /// <param name="operationalStatusDescriptor">The current operational status of the EducationOrganization (e.g., active, inactive)..</param>
        /// <param name="schoolCategories">An unordered collection of schoolCategories. The one or more categories of school. For example: High School, Middle School, and/or Elementary School..</param>
        /// <param name="schoolTypeDescriptor">The type of education institution as classified by its primary focus..</param>
        /// <param name="shortNameOfInstitution">A short name for the institution..</param>
        /// <param name="titleIPartASchoolDesignationDescriptor">Denotes the Title I Part A designation for the school..</param>
        /// <param name="webSite">The public web site address (URL) for the EducationOrganization..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiSchool(string id = default(string), List<EdFiEducationOrganizationCategory> educationOrganizationCategories = default(List<EdFiEducationOrganizationCategory>), List<EdFiSchoolGradeLevel> gradeLevels = default(List<EdFiSchoolGradeLevel>), int? schoolId = default(int?), EdFiSchoolYearTypeReference charterApprovalSchoolYearTypeReference = default(EdFiSchoolYearTypeReference), EdFiLocalEducationAgencyReference localEducationAgencyReference = default(EdFiLocalEducationAgencyReference), List<EdFiEducationOrganizationAddress> addresses = default(List<EdFiEducationOrganizationAddress>), string administrativeFundingControlDescriptor = default(string), string charterApprovalAgencyTypeDescriptor = default(string), string charterStatusDescriptor = default(string), List<EdFiEducationOrganizationIdentificationCode> identificationCodes = default(List<EdFiEducationOrganizationIdentificationCode>), List<EdFiEducationOrganizationIndicator> indicators = default(List<EdFiEducationOrganizationIndicator>), List<EdFiEducationOrganizationInstitutionTelephone> institutionTelephones = default(List<EdFiEducationOrganizationInstitutionTelephone>), List<EdFiEducationOrganizationInternationalAddress> internationalAddresses = default(List<EdFiEducationOrganizationInternationalAddress>), string internetAccessDescriptor = default(string), string magnetSpecialProgramEmphasisSchoolDescriptor = default(string), string nameOfInstitution = default(string), string operationalStatusDescriptor = default(string), List<EdFiSchoolCategory> schoolCategories = default(List<EdFiSchoolCategory>), string schoolTypeDescriptor = default(string), string shortNameOfInstitution = default(string), string titleIPartASchoolDesignationDescriptor = default(string), string webSite = default(string), string etag = default(string), SchoolExtensions ext = default(SchoolExtensions))
        {
            // to ensure "educationOrganizationCategories" is required (not null)
            if (educationOrganizationCategories == null)
            {
                throw new InvalidDataException("educationOrganizationCategories is a required property for EdFiSchool and cannot be null");
            }
            else
            {
                this.EducationOrganizationCategories = educationOrganizationCategories;
            }
            // to ensure "gradeLevels" is required (not null)
            if (gradeLevels == null)
            {
                throw new InvalidDataException("gradeLevels is a required property for EdFiSchool and cannot be null");
            }
            else
            {
                this.GradeLevels = gradeLevels;
            }
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiSchool and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            // to ensure "nameOfInstitution" is required (not null)
            if (nameOfInstitution == null)
            {
                throw new InvalidDataException("nameOfInstitution is a required property for EdFiSchool and cannot be null");
            }
            else
            {
                this.NameOfInstitution = nameOfInstitution;
            }
            this.Id = id;
            this.CharterApprovalSchoolYearTypeReference = charterApprovalSchoolYearTypeReference;
            this.LocalEducationAgencyReference = localEducationAgencyReference;
            this.Addresses = addresses;
            this.AdministrativeFundingControlDescriptor = administrativeFundingControlDescriptor;
            this.CharterApprovalAgencyTypeDescriptor = charterApprovalAgencyTypeDescriptor;
            this.CharterStatusDescriptor = charterStatusDescriptor;
            this.IdentificationCodes = identificationCodes;
            this.Indicators = indicators;
            this.InstitutionTelephones = institutionTelephones;
            this.InternationalAddresses = internationalAddresses;
            this.InternetAccessDescriptor = internetAccessDescriptor;
            this.MagnetSpecialProgramEmphasisSchoolDescriptor = magnetSpecialProgramEmphasisSchoolDescriptor;
            this.OperationalStatusDescriptor = operationalStatusDescriptor;
            this.SchoolCategories = schoolCategories;
            this.SchoolTypeDescriptor = schoolTypeDescriptor;
            this.ShortNameOfInstitution = shortNameOfInstitution;
            this.TitleIPartASchoolDesignationDescriptor = titleIPartASchoolDesignationDescriptor;
            this.WebSite = webSite;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.</value>
        [DataMember(Name="educationOrganizationCategories", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationCategory> EducationOrganizationCategories { get; set; }

        /// <summary>
        /// An unordered collection of schoolGradeLevels. The grade levels served at the school.
        /// </summary>
        /// <value>An unordered collection of schoolGradeLevels. The grade levels served at the school.</value>
        [DataMember(Name="gradeLevels", EmitDefaultValue=false)]
        public List<EdFiSchoolGradeLevel> GradeLevels { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="schoolId", EmitDefaultValue=false)]
        public int? SchoolId { get; set; }

        /// <summary>
        /// Gets or Sets CharterApprovalSchoolYearTypeReference
        /// </summary>
        [DataMember(Name="charterApprovalSchoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference CharterApprovalSchoolYearTypeReference { get; set; }

        /// <summary>
        /// Gets or Sets LocalEducationAgencyReference
        /// </summary>
        [DataMember(Name="localEducationAgencyReference", EmitDefaultValue=false)]
        public EdFiLocalEducationAgencyReference LocalEducationAgencyReference { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationAddresses. The set of elements that describes the physical location of the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationAddresses. The set of elements that describes the physical location of the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationAddress> Addresses { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source, for example public or private.
        /// </summary>
        /// <value>The type of education institution as classified by its funding source, for example public or private.</value>
        [DataMember(Name="administrativeFundingControlDescriptor", EmitDefaultValue=false)]
        public string AdministrativeFundingControlDescriptor { get; set; }

        /// <summary>
        /// The type of agency that approved the establishment or continuation of a charter school.
        /// </summary>
        /// <value>The type of agency that approved the establishment or continuation of a charter school.</value>
        [DataMember(Name="charterApprovalAgencyTypeDescriptor", EmitDefaultValue=false)]
        public string CharterApprovalAgencyTypeDescriptor { get; set; }

        /// <summary>
        /// A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school.
        /// </summary>
        /// <value>A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school.</value>
        [DataMember(Name="charterStatusDescriptor", EmitDefaultValue=false)]
        public string CharterStatusDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name="identificationCodes", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationIdentificationCode> IdentificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIndicators. An indicator or metric of an Education Organization.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIndicators. An indicator or metric of an Education Organization.</value>
        [DataMember(Name="indicators", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationIndicator> Indicators { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity.</value>
        [DataMember(Name="institutionTelephones", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationInstitutionTelephone> InstitutionTelephones { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity.</value>
        [DataMember(Name="internationalAddresses", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationInternationalAddress> InternationalAddresses { get; set; }

        /// <summary>
        /// The type of Internet access available.
        /// </summary>
        /// <value>The type of Internet access available.</value>
        [DataMember(Name="internetAccessDescriptor", EmitDefaultValue=false)]
        public string InternetAccessDescriptor { get; set; }

        /// <summary>
        /// A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2) to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, or foreign language).
        /// </summary>
        /// <value>A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2) to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, or foreign language).</value>
        [DataMember(Name="magnetSpecialProgramEmphasisSchoolDescriptor", EmitDefaultValue=false)]
        public string MagnetSpecialProgramEmphasisSchoolDescriptor { get; set; }

        /// <summary>
        /// The full, legally accepted name of the institution.
        /// </summary>
        /// <value>The full, legally accepted name of the institution.</value>
        [DataMember(Name="nameOfInstitution", EmitDefaultValue=false)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// The current operational status of the EducationOrganization (e.g., active, inactive).
        /// </summary>
        /// <value>The current operational status of the EducationOrganization (e.g., active, inactive).</value>
        [DataMember(Name="operationalStatusDescriptor", EmitDefaultValue=false)]
        public string OperationalStatusDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of schoolCategories. The one or more categories of school. For example: High School, Middle School, and/or Elementary School.
        /// </summary>
        /// <value>An unordered collection of schoolCategories. The one or more categories of school. For example: High School, Middle School, and/or Elementary School.</value>
        [DataMember(Name="schoolCategories", EmitDefaultValue=false)]
        public List<EdFiSchoolCategory> SchoolCategories { get; set; }

        /// <summary>
        /// The type of education institution as classified by its primary focus.
        /// </summary>
        /// <value>The type of education institution as classified by its primary focus.</value>
        [DataMember(Name="schoolTypeDescriptor", EmitDefaultValue=false)]
        public string SchoolTypeDescriptor { get; set; }

        /// <summary>
        /// A short name for the institution.
        /// </summary>
        /// <value>A short name for the institution.</value>
        [DataMember(Name="shortNameOfInstitution", EmitDefaultValue=false)]
        public string ShortNameOfInstitution { get; set; }

        /// <summary>
        /// Denotes the Title I Part A designation for the school.
        /// </summary>
        /// <value>Denotes the Title I Part A designation for the school.</value>
        [DataMember(Name="titleIPartASchoolDesignationDescriptor", EmitDefaultValue=false)]
        public string TitleIPartASchoolDesignationDescriptor { get; set; }

        /// <summary>
        /// The public web site address (URL) for the EducationOrganization.
        /// </summary>
        /// <value>The public web site address (URL) for the EducationOrganization.</value>
        [DataMember(Name="webSite", EmitDefaultValue=false)]
        public string WebSite { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public SchoolExtensions Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSchool {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationCategories: ").Append(EducationOrganizationCategories).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  CharterApprovalSchoolYearTypeReference: ").Append(CharterApprovalSchoolYearTypeReference).Append("\n");
            sb.Append("  LocalEducationAgencyReference: ").Append(LocalEducationAgencyReference).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  AdministrativeFundingControlDescriptor: ").Append(AdministrativeFundingControlDescriptor).Append("\n");
            sb.Append("  CharterApprovalAgencyTypeDescriptor: ").Append(CharterApprovalAgencyTypeDescriptor).Append("\n");
            sb.Append("  CharterStatusDescriptor: ").Append(CharterStatusDescriptor).Append("\n");
            sb.Append("  IdentificationCodes: ").Append(IdentificationCodes).Append("\n");
            sb.Append("  Indicators: ").Append(Indicators).Append("\n");
            sb.Append("  InstitutionTelephones: ").Append(InstitutionTelephones).Append("\n");
            sb.Append("  InternationalAddresses: ").Append(InternationalAddresses).Append("\n");
            sb.Append("  InternetAccessDescriptor: ").Append(InternetAccessDescriptor).Append("\n");
            sb.Append("  MagnetSpecialProgramEmphasisSchoolDescriptor: ").Append(MagnetSpecialProgramEmphasisSchoolDescriptor).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  OperationalStatusDescriptor: ").Append(OperationalStatusDescriptor).Append("\n");
            sb.Append("  SchoolCategories: ").Append(SchoolCategories).Append("\n");
            sb.Append("  SchoolTypeDescriptor: ").Append(SchoolTypeDescriptor).Append("\n");
            sb.Append("  ShortNameOfInstitution: ").Append(ShortNameOfInstitution).Append("\n");
            sb.Append("  TitleIPartASchoolDesignationDescriptor: ").Append(TitleIPartASchoolDesignationDescriptor).Append("\n");
            sb.Append("  WebSite: ").Append(WebSite).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiSchool);
        }

        /// <summary>
        /// Returns true if EdFiSchool instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSchool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSchool input)
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
                    this.EducationOrganizationCategories == input.EducationOrganizationCategories ||
                    this.EducationOrganizationCategories != null &&
                    this.EducationOrganizationCategories.SequenceEqual(input.EducationOrganizationCategories)
                ) && 
                (
                    this.GradeLevels == input.GradeLevels ||
                    this.GradeLevels != null &&
                    this.GradeLevels.SequenceEqual(input.GradeLevels)
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.CharterApprovalSchoolYearTypeReference == input.CharterApprovalSchoolYearTypeReference ||
                    (this.CharterApprovalSchoolYearTypeReference != null &&
                    this.CharterApprovalSchoolYearTypeReference.Equals(input.CharterApprovalSchoolYearTypeReference))
                ) && 
                (
                    this.LocalEducationAgencyReference == input.LocalEducationAgencyReference ||
                    (this.LocalEducationAgencyReference != null &&
                    this.LocalEducationAgencyReference.Equals(input.LocalEducationAgencyReference))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.AdministrativeFundingControlDescriptor == input.AdministrativeFundingControlDescriptor ||
                    (this.AdministrativeFundingControlDescriptor != null &&
                    this.AdministrativeFundingControlDescriptor.Equals(input.AdministrativeFundingControlDescriptor))
                ) && 
                (
                    this.CharterApprovalAgencyTypeDescriptor == input.CharterApprovalAgencyTypeDescriptor ||
                    (this.CharterApprovalAgencyTypeDescriptor != null &&
                    this.CharterApprovalAgencyTypeDescriptor.Equals(input.CharterApprovalAgencyTypeDescriptor))
                ) && 
                (
                    this.CharterStatusDescriptor == input.CharterStatusDescriptor ||
                    (this.CharterStatusDescriptor != null &&
                    this.CharterStatusDescriptor.Equals(input.CharterStatusDescriptor))
                ) && 
                (
                    this.IdentificationCodes == input.IdentificationCodes ||
                    this.IdentificationCodes != null &&
                    this.IdentificationCodes.SequenceEqual(input.IdentificationCodes)
                ) && 
                (
                    this.Indicators == input.Indicators ||
                    this.Indicators != null &&
                    this.Indicators.SequenceEqual(input.Indicators)
                ) && 
                (
                    this.InstitutionTelephones == input.InstitutionTelephones ||
                    this.InstitutionTelephones != null &&
                    this.InstitutionTelephones.SequenceEqual(input.InstitutionTelephones)
                ) && 
                (
                    this.InternationalAddresses == input.InternationalAddresses ||
                    this.InternationalAddresses != null &&
                    this.InternationalAddresses.SequenceEqual(input.InternationalAddresses)
                ) && 
                (
                    this.InternetAccessDescriptor == input.InternetAccessDescriptor ||
                    (this.InternetAccessDescriptor != null &&
                    this.InternetAccessDescriptor.Equals(input.InternetAccessDescriptor))
                ) && 
                (
                    this.MagnetSpecialProgramEmphasisSchoolDescriptor == input.MagnetSpecialProgramEmphasisSchoolDescriptor ||
                    (this.MagnetSpecialProgramEmphasisSchoolDescriptor != null &&
                    this.MagnetSpecialProgramEmphasisSchoolDescriptor.Equals(input.MagnetSpecialProgramEmphasisSchoolDescriptor))
                ) && 
                (
                    this.NameOfInstitution == input.NameOfInstitution ||
                    (this.NameOfInstitution != null &&
                    this.NameOfInstitution.Equals(input.NameOfInstitution))
                ) && 
                (
                    this.OperationalStatusDescriptor == input.OperationalStatusDescriptor ||
                    (this.OperationalStatusDescriptor != null &&
                    this.OperationalStatusDescriptor.Equals(input.OperationalStatusDescriptor))
                ) && 
                (
                    this.SchoolCategories == input.SchoolCategories ||
                    this.SchoolCategories != null &&
                    this.SchoolCategories.SequenceEqual(input.SchoolCategories)
                ) && 
                (
                    this.SchoolTypeDescriptor == input.SchoolTypeDescriptor ||
                    (this.SchoolTypeDescriptor != null &&
                    this.SchoolTypeDescriptor.Equals(input.SchoolTypeDescriptor))
                ) && 
                (
                    this.ShortNameOfInstitution == input.ShortNameOfInstitution ||
                    (this.ShortNameOfInstitution != null &&
                    this.ShortNameOfInstitution.Equals(input.ShortNameOfInstitution))
                ) && 
                (
                    this.TitleIPartASchoolDesignationDescriptor == input.TitleIPartASchoolDesignationDescriptor ||
                    (this.TitleIPartASchoolDesignationDescriptor != null &&
                    this.TitleIPartASchoolDesignationDescriptor.Equals(input.TitleIPartASchoolDesignationDescriptor))
                ) && 
                (
                    this.WebSite == input.WebSite ||
                    (this.WebSite != null &&
                    this.WebSite.Equals(input.WebSite))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                if (this.EducationOrganizationCategories != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationCategories.GetHashCode();
                if (this.GradeLevels != null)
                    hashCode = hashCode * 59 + this.GradeLevels.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.CharterApprovalSchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.CharterApprovalSchoolYearTypeReference.GetHashCode();
                if (this.LocalEducationAgencyReference != null)
                    hashCode = hashCode * 59 + this.LocalEducationAgencyReference.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.AdministrativeFundingControlDescriptor != null)
                    hashCode = hashCode * 59 + this.AdministrativeFundingControlDescriptor.GetHashCode();
                if (this.CharterApprovalAgencyTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.CharterApprovalAgencyTypeDescriptor.GetHashCode();
                if (this.CharterStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.CharterStatusDescriptor.GetHashCode();
                if (this.IdentificationCodes != null)
                    hashCode = hashCode * 59 + this.IdentificationCodes.GetHashCode();
                if (this.Indicators != null)
                    hashCode = hashCode * 59 + this.Indicators.GetHashCode();
                if (this.InstitutionTelephones != null)
                    hashCode = hashCode * 59 + this.InstitutionTelephones.GetHashCode();
                if (this.InternationalAddresses != null)
                    hashCode = hashCode * 59 + this.InternationalAddresses.GetHashCode();
                if (this.InternetAccessDescriptor != null)
                    hashCode = hashCode * 59 + this.InternetAccessDescriptor.GetHashCode();
                if (this.MagnetSpecialProgramEmphasisSchoolDescriptor != null)
                    hashCode = hashCode * 59 + this.MagnetSpecialProgramEmphasisSchoolDescriptor.GetHashCode();
                if (this.NameOfInstitution != null)
                    hashCode = hashCode * 59 + this.NameOfInstitution.GetHashCode();
                if (this.OperationalStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.OperationalStatusDescriptor.GetHashCode();
                if (this.SchoolCategories != null)
                    hashCode = hashCode * 59 + this.SchoolCategories.GetHashCode();
                if (this.SchoolTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.SchoolTypeDescriptor.GetHashCode();
                if (this.ShortNameOfInstitution != null)
                    hashCode = hashCode * 59 + this.ShortNameOfInstitution.GetHashCode();
                if (this.TitleIPartASchoolDesignationDescriptor != null)
                    hashCode = hashCode * 59 + this.TitleIPartASchoolDesignationDescriptor.GetHashCode();
                if (this.WebSite != null)
                    hashCode = hashCode * 59 + this.WebSite.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
