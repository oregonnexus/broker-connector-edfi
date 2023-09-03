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
    /// EdFiCredential
    /// </summary>
    [DataContract]
    public partial class EdFiCredential :  IEquatable<EdFiCredential>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCredential" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCredential() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCredential" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="credentialIdentifier">Identifier or serial number assigned to the credential. (required).</param>
        /// <param name="gradeLevels">An unordered collection of credentialGradeLevels. The grade level(s) certified for teaching. (required).</param>
        /// <param name="stateOfIssueStateAbbreviationDescriptor">The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. (required).</param>
        /// <param name="academicSubjects">An unordered collection of credentialAcademicSubjects. The academic subjects to which the credential pertains..</param>
        /// <param name="credentialFieldDescriptor">The field of certification for the certificate (e.g., Mathematics, Music). (required).</param>
        /// <param name="credentialTypeDescriptor">An indication of the category of credential an individual holds. (required).</param>
        /// <param name="effectiveDate">The year, month and day on which an active credential held by an individual was issued..</param>
        /// <param name="endorsements">An unordered collection of credentialEndorsements. Endorsements are attachments to teaching certificates and indicate areas of specialization..</param>
        /// <param name="expirationDate">The month, day, and year on which an active credential held by an individual will expire..</param>
        /// <param name="issuanceDate">The month, day, and year on which an active credential was issued to an individual. (required).</param>
        /// <param name="_namespace">Namespace for the Credential. (required).</param>
        /// <param name="teachingCredentialBasisDescriptor">An indication of the pre-determined criteria for granting the teaching credential that an individual holds..</param>
        /// <param name="teachingCredentialDescriptor">An indication of the category of a legal document giving authorization to perform teaching assignment services. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiCredential(string id = default(string), string credentialIdentifier = default(string), List<EdFiCredentialGradeLevel> gradeLevels = default(List<EdFiCredentialGradeLevel>), string stateOfIssueStateAbbreviationDescriptor = default(string), List<EdFiCredentialAcademicSubject> academicSubjects = default(List<EdFiCredentialAcademicSubject>), string credentialFieldDescriptor = default(string), string credentialTypeDescriptor = default(string), DateTime? effectiveDate = default(DateTime?), List<EdFiCredentialEndorsement> endorsements = default(List<EdFiCredentialEndorsement>), DateTime? expirationDate = default(DateTime?), DateTime? issuanceDate = default(DateTime?), string _namespace = default(string), string teachingCredentialBasisDescriptor = default(string), string teachingCredentialDescriptor = default(string), string etag = default(string), CredentialExtensions ext = default(CredentialExtensions))
        {
            // to ensure "credentialIdentifier" is required (not null)
            if (credentialIdentifier == null)
            {
                throw new InvalidDataException("credentialIdentifier is a required property for EdFiCredential and cannot be null");
            }
            else
            {
                this.CredentialIdentifier = credentialIdentifier;
            }
            // to ensure "gradeLevels" is required (not null)
            if (gradeLevels == null)
            {
                throw new InvalidDataException("gradeLevels is a required property for EdFiCredential and cannot be null");
            }
            else
            {
                this.GradeLevels = gradeLevels;
            }
            // to ensure "stateOfIssueStateAbbreviationDescriptor" is required (not null)
            if (stateOfIssueStateAbbreviationDescriptor == null)
            {
                throw new InvalidDataException("stateOfIssueStateAbbreviationDescriptor is a required property for EdFiCredential and cannot be null");
            }
            else
            {
                this.StateOfIssueStateAbbreviationDescriptor = stateOfIssueStateAbbreviationDescriptor;
            }
            // to ensure "credentialFieldDescriptor" is required (not null)
            if (credentialFieldDescriptor == null)
            {
                throw new InvalidDataException("credentialFieldDescriptor is a required property for EdFiCredential and cannot be null");
            }
            else
            {
                this.CredentialFieldDescriptor = credentialFieldDescriptor;
            }
            // to ensure "credentialTypeDescriptor" is required (not null)
            if (credentialTypeDescriptor == null)
            {
                throw new InvalidDataException("credentialTypeDescriptor is a required property for EdFiCredential and cannot be null");
            }
            else
            {
                this.CredentialTypeDescriptor = credentialTypeDescriptor;
            }
            // to ensure "issuanceDate" is required (not null)
            if (issuanceDate == null)
            {
                throw new InvalidDataException("issuanceDate is a required property for EdFiCredential and cannot be null");
            }
            else
            {
                this.IssuanceDate = issuanceDate;
            }
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for EdFiCredential and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }
            // to ensure "teachingCredentialDescriptor" is required (not null)
            if (teachingCredentialDescriptor == null)
            {
                throw new InvalidDataException("teachingCredentialDescriptor is a required property for EdFiCredential and cannot be null");
            }
            else
            {
                this.TeachingCredentialDescriptor = teachingCredentialDescriptor;
            }
            this.Id = id;
            this.AcademicSubjects = academicSubjects;
            this.EffectiveDate = effectiveDate;
            this.Endorsements = endorsements;
            this.ExpirationDate = expirationDate;
            this.TeachingCredentialBasisDescriptor = teachingCredentialBasisDescriptor;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Identifier or serial number assigned to the credential.
        /// </summary>
        /// <value>Identifier or serial number assigned to the credential.</value>
        [DataMember(Name="credentialIdentifier", EmitDefaultValue=false)]
        public string CredentialIdentifier { get; set; }

        /// <summary>
        /// An unordered collection of credentialGradeLevels. The grade level(s) certified for teaching.
        /// </summary>
        /// <value>An unordered collection of credentialGradeLevels. The grade level(s) certified for teaching.</value>
        [DataMember(Name="gradeLevels", EmitDefaultValue=false)]
        public List<EdFiCredentialGradeLevel> GradeLevels { get; set; }

        /// <summary>
        /// The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued.
        /// </summary>
        /// <value>The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued.</value>
        [DataMember(Name="stateOfIssueStateAbbreviationDescriptor", EmitDefaultValue=false)]
        public string StateOfIssueStateAbbreviationDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of credentialAcademicSubjects. The academic subjects to which the credential pertains.
        /// </summary>
        /// <value>An unordered collection of credentialAcademicSubjects. The academic subjects to which the credential pertains.</value>
        [DataMember(Name="academicSubjects", EmitDefaultValue=false)]
        public List<EdFiCredentialAcademicSubject> AcademicSubjects { get; set; }

        /// <summary>
        /// The field of certification for the certificate (e.g., Mathematics, Music).
        /// </summary>
        /// <value>The field of certification for the certificate (e.g., Mathematics, Music).</value>
        [DataMember(Name="credentialFieldDescriptor", EmitDefaultValue=false)]
        public string CredentialFieldDescriptor { get; set; }

        /// <summary>
        /// An indication of the category of credential an individual holds.
        /// </summary>
        /// <value>An indication of the category of credential an individual holds.</value>
        [DataMember(Name="credentialTypeDescriptor", EmitDefaultValue=false)]
        public string CredentialTypeDescriptor { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by an individual was issued.
        /// </summary>
        /// <value>The year, month and day on which an active credential held by an individual was issued.</value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// An unordered collection of credentialEndorsements. Endorsements are attachments to teaching certificates and indicate areas of specialization.
        /// </summary>
        /// <value>An unordered collection of credentialEndorsements. Endorsements are attachments to teaching certificates and indicate areas of specialization.</value>
        [DataMember(Name="endorsements", EmitDefaultValue=false)]
        public List<EdFiCredentialEndorsement> Endorsements { get; set; }

        /// <summary>
        /// The month, day, and year on which an active credential held by an individual will expire.
        /// </summary>
        /// <value>The month, day, and year on which an active credential held by an individual will expire.</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The month, day, and year on which an active credential was issued to an individual.
        /// </summary>
        /// <value>The month, day, and year on which an active credential was issued to an individual.</value>
        [DataMember(Name="issuanceDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? IssuanceDate { get; set; }

        /// <summary>
        /// Namespace for the Credential.
        /// </summary>
        /// <value>Namespace for the Credential.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// An indication of the pre-determined criteria for granting the teaching credential that an individual holds.
        /// </summary>
        /// <value>An indication of the pre-determined criteria for granting the teaching credential that an individual holds.</value>
        [DataMember(Name="teachingCredentialBasisDescriptor", EmitDefaultValue=false)]
        public string TeachingCredentialBasisDescriptor { get; set; }

        /// <summary>
        /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
        /// </summary>
        /// <value>An indication of the category of a legal document giving authorization to perform teaching assignment services.</value>
        [DataMember(Name="teachingCredentialDescriptor", EmitDefaultValue=false)]
        public string TeachingCredentialDescriptor { get; set; }

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
        public CredentialExtensions Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCredential {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CredentialIdentifier: ").Append(CredentialIdentifier).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
            sb.Append("  StateOfIssueStateAbbreviationDescriptor: ").Append(StateOfIssueStateAbbreviationDescriptor).Append("\n");
            sb.Append("  AcademicSubjects: ").Append(AcademicSubjects).Append("\n");
            sb.Append("  CredentialFieldDescriptor: ").Append(CredentialFieldDescriptor).Append("\n");
            sb.Append("  CredentialTypeDescriptor: ").Append(CredentialTypeDescriptor).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  Endorsements: ").Append(Endorsements).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IssuanceDate: ").Append(IssuanceDate).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  TeachingCredentialBasisDescriptor: ").Append(TeachingCredentialBasisDescriptor).Append("\n");
            sb.Append("  TeachingCredentialDescriptor: ").Append(TeachingCredentialDescriptor).Append("\n");
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
            return this.Equals(input as EdFiCredential);
        }

        /// <summary>
        /// Returns true if EdFiCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCredential input)
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
                    this.CredentialIdentifier == input.CredentialIdentifier ||
                    (this.CredentialIdentifier != null &&
                    this.CredentialIdentifier.Equals(input.CredentialIdentifier))
                ) && 
                (
                    this.GradeLevels == input.GradeLevels ||
                    this.GradeLevels != null &&
                    this.GradeLevels.SequenceEqual(input.GradeLevels)
                ) && 
                (
                    this.StateOfIssueStateAbbreviationDescriptor == input.StateOfIssueStateAbbreviationDescriptor ||
                    (this.StateOfIssueStateAbbreviationDescriptor != null &&
                    this.StateOfIssueStateAbbreviationDescriptor.Equals(input.StateOfIssueStateAbbreviationDescriptor))
                ) && 
                (
                    this.AcademicSubjects == input.AcademicSubjects ||
                    this.AcademicSubjects != null &&
                    this.AcademicSubjects.SequenceEqual(input.AcademicSubjects)
                ) && 
                (
                    this.CredentialFieldDescriptor == input.CredentialFieldDescriptor ||
                    (this.CredentialFieldDescriptor != null &&
                    this.CredentialFieldDescriptor.Equals(input.CredentialFieldDescriptor))
                ) && 
                (
                    this.CredentialTypeDescriptor == input.CredentialTypeDescriptor ||
                    (this.CredentialTypeDescriptor != null &&
                    this.CredentialTypeDescriptor.Equals(input.CredentialTypeDescriptor))
                ) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.Endorsements == input.Endorsements ||
                    this.Endorsements != null &&
                    this.Endorsements.SequenceEqual(input.Endorsements)
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.IssuanceDate == input.IssuanceDate ||
                    (this.IssuanceDate != null &&
                    this.IssuanceDate.Equals(input.IssuanceDate))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.TeachingCredentialBasisDescriptor == input.TeachingCredentialBasisDescriptor ||
                    (this.TeachingCredentialBasisDescriptor != null &&
                    this.TeachingCredentialBasisDescriptor.Equals(input.TeachingCredentialBasisDescriptor))
                ) && 
                (
                    this.TeachingCredentialDescriptor == input.TeachingCredentialDescriptor ||
                    (this.TeachingCredentialDescriptor != null &&
                    this.TeachingCredentialDescriptor.Equals(input.TeachingCredentialDescriptor))
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
                if (this.CredentialIdentifier != null)
                    hashCode = hashCode * 59 + this.CredentialIdentifier.GetHashCode();
                if (this.GradeLevels != null)
                    hashCode = hashCode * 59 + this.GradeLevels.GetHashCode();
                if (this.StateOfIssueStateAbbreviationDescriptor != null)
                    hashCode = hashCode * 59 + this.StateOfIssueStateAbbreviationDescriptor.GetHashCode();
                if (this.AcademicSubjects != null)
                    hashCode = hashCode * 59 + this.AcademicSubjects.GetHashCode();
                if (this.CredentialFieldDescriptor != null)
                    hashCode = hashCode * 59 + this.CredentialFieldDescriptor.GetHashCode();
                if (this.CredentialTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.CredentialTypeDescriptor.GetHashCode();
                if (this.EffectiveDate != null)
                    hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.Endorsements != null)
                    hashCode = hashCode * 59 + this.Endorsements.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.IssuanceDate != null)
                    hashCode = hashCode * 59 + this.IssuanceDate.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.TeachingCredentialBasisDescriptor != null)
                    hashCode = hashCode * 59 + this.TeachingCredentialBasisDescriptor.GetHashCode();
                if (this.TeachingCredentialDescriptor != null)
                    hashCode = hashCode * 59 + this.TeachingCredentialDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
