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
    /// EdFiGraduationPlan
    /// </summary>
    [DataContract]
    public partial class EdFiGraduationPlan :  IEquatable<EdFiGraduationPlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGraduationPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlan" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="graduationPlanTypeDescriptor">The type of academic plan the student is following for graduation: for example, Minimum, Recommended, Distinguished, or Standard. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="graduationSchoolYearTypeReference">graduationSchoolYearTypeReference (required).</param>
        /// <param name="creditsByCourses">An unordered collection of graduationPlanCreditsByCourses. The total credits required for graduation by taking a specific course, or by taking one or more from a set of courses..</param>
        /// <param name="creditsByCreditCategories">An unordered collection of graduationPlanCreditsByCreditCategories. The total credits required for graduation based on the credit category..</param>
        /// <param name="creditsBySubjects">An unordered collection of graduationPlanCreditsBySubjects. The total credits required in subject to graduate. Only those courses identified as a high school course requirement are eligible to meet subject credit requirements..</param>
        /// <param name="individualPlan">An indicator of whether the GraduationPlan is tailored for an individual..</param>
        /// <param name="requiredAssessments">An unordered collection of graduationPlanRequiredAssessments. The assessments and associated required score and performance level needed to satisfy graduation requirements..</param>
        /// <param name="totalRequiredCreditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="totalRequiredCredits">The value of credits or units of value awarded for the completion of a course. (required).</param>
        /// <param name="totalRequiredCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiGraduationPlan(string id = default(string), string graduationPlanTypeDescriptor = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiSchoolYearTypeReference graduationSchoolYearTypeReference = default(EdFiSchoolYearTypeReference), List<EdFiGraduationPlanCreditsByCourse> creditsByCourses = default(List<EdFiGraduationPlanCreditsByCourse>), List<EdFiGraduationPlanCreditsByCreditCategory> creditsByCreditCategories = default(List<EdFiGraduationPlanCreditsByCreditCategory>), List<EdFiGraduationPlanCreditsBySubject> creditsBySubjects = default(List<EdFiGraduationPlanCreditsBySubject>), bool? individualPlan = default(bool?), List<EdFiGraduationPlanRequiredAssessment> requiredAssessments = default(List<EdFiGraduationPlanRequiredAssessment>), double? totalRequiredCreditConversion = default(double?), double? totalRequiredCredits = default(double?), string totalRequiredCreditTypeDescriptor = default(string), string etag = default(string), GraduationPlanExtensions ext = default(GraduationPlanExtensions))
        {
            // to ensure "graduationPlanTypeDescriptor" is required (not null)
            if (graduationPlanTypeDescriptor == null)
            {
                throw new InvalidDataException("graduationPlanTypeDescriptor is a required property for EdFiGraduationPlan and cannot be null");
            }
            else
            {
                this.GraduationPlanTypeDescriptor = graduationPlanTypeDescriptor;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiGraduationPlan and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "graduationSchoolYearTypeReference" is required (not null)
            if (graduationSchoolYearTypeReference == null)
            {
                throw new InvalidDataException("graduationSchoolYearTypeReference is a required property for EdFiGraduationPlan and cannot be null");
            }
            else
            {
                this.GraduationSchoolYearTypeReference = graduationSchoolYearTypeReference;
            }
            // to ensure "totalRequiredCredits" is required (not null)
            if (totalRequiredCredits == null)
            {
                throw new InvalidDataException("totalRequiredCredits is a required property for EdFiGraduationPlan and cannot be null");
            }
            else
            {
                this.TotalRequiredCredits = totalRequiredCredits;
            }
            this.Id = id;
            this.CreditsByCourses = creditsByCourses;
            this.CreditsByCreditCategories = creditsByCreditCategories;
            this.CreditsBySubjects = creditsBySubjects;
            this.IndividualPlan = individualPlan;
            this.RequiredAssessments = requiredAssessments;
            this.TotalRequiredCreditConversion = totalRequiredCreditConversion;
            this.TotalRequiredCreditTypeDescriptor = totalRequiredCreditTypeDescriptor;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The type of academic plan the student is following for graduation: for example, Minimum, Recommended, Distinguished, or Standard.
        /// </summary>
        /// <value>The type of academic plan the student is following for graduation: for example, Minimum, Recommended, Distinguished, or Standard.</value>
        [DataMember(Name="graduationPlanTypeDescriptor", EmitDefaultValue=false)]
        public string GraduationPlanTypeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets GraduationSchoolYearTypeReference
        /// </summary>
        [DataMember(Name="graduationSchoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference GraduationSchoolYearTypeReference { get; set; }

        /// <summary>
        /// An unordered collection of graduationPlanCreditsByCourses. The total credits required for graduation by taking a specific course, or by taking one or more from a set of courses.
        /// </summary>
        /// <value>An unordered collection of graduationPlanCreditsByCourses. The total credits required for graduation by taking a specific course, or by taking one or more from a set of courses.</value>
        [DataMember(Name="creditsByCourses", EmitDefaultValue=false)]
        public List<EdFiGraduationPlanCreditsByCourse> CreditsByCourses { get; set; }

        /// <summary>
        /// An unordered collection of graduationPlanCreditsByCreditCategories. The total credits required for graduation based on the credit category.
        /// </summary>
        /// <value>An unordered collection of graduationPlanCreditsByCreditCategories. The total credits required for graduation based on the credit category.</value>
        [DataMember(Name="creditsByCreditCategories", EmitDefaultValue=false)]
        public List<EdFiGraduationPlanCreditsByCreditCategory> CreditsByCreditCategories { get; set; }

        /// <summary>
        /// An unordered collection of graduationPlanCreditsBySubjects. The total credits required in subject to graduate. Only those courses identified as a high school course requirement are eligible to meet subject credit requirements.
        /// </summary>
        /// <value>An unordered collection of graduationPlanCreditsBySubjects. The total credits required in subject to graduate. Only those courses identified as a high school course requirement are eligible to meet subject credit requirements.</value>
        [DataMember(Name="creditsBySubjects", EmitDefaultValue=false)]
        public List<EdFiGraduationPlanCreditsBySubject> CreditsBySubjects { get; set; }

        /// <summary>
        /// An indicator of whether the GraduationPlan is tailored for an individual.
        /// </summary>
        /// <value>An indicator of whether the GraduationPlan is tailored for an individual.</value>
        [DataMember(Name="individualPlan", EmitDefaultValue=false)]
        public bool? IndividualPlan { get; set; }

        /// <summary>
        /// An unordered collection of graduationPlanRequiredAssessments. The assessments and associated required score and performance level needed to satisfy graduation requirements.
        /// </summary>
        /// <value>An unordered collection of graduationPlanRequiredAssessments. The assessments and associated required score and performance level needed to satisfy graduation requirements.</value>
        [DataMember(Name="requiredAssessments", EmitDefaultValue=false)]
        public List<EdFiGraduationPlanRequiredAssessment> RequiredAssessments { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name="totalRequiredCreditConversion", EmitDefaultValue=false)]
        public double? TotalRequiredCreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="totalRequiredCredits", EmitDefaultValue=false)]
        public double? TotalRequiredCredits { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="totalRequiredCreditTypeDescriptor", EmitDefaultValue=false)]
        public string TotalRequiredCreditTypeDescriptor { get; set; }

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
        public GraduationPlanExtensions Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiGraduationPlan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GraduationPlanTypeDescriptor: ").Append(GraduationPlanTypeDescriptor).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  GraduationSchoolYearTypeReference: ").Append(GraduationSchoolYearTypeReference).Append("\n");
            sb.Append("  CreditsByCourses: ").Append(CreditsByCourses).Append("\n");
            sb.Append("  CreditsByCreditCategories: ").Append(CreditsByCreditCategories).Append("\n");
            sb.Append("  CreditsBySubjects: ").Append(CreditsBySubjects).Append("\n");
            sb.Append("  IndividualPlan: ").Append(IndividualPlan).Append("\n");
            sb.Append("  RequiredAssessments: ").Append(RequiredAssessments).Append("\n");
            sb.Append("  TotalRequiredCreditConversion: ").Append(TotalRequiredCreditConversion).Append("\n");
            sb.Append("  TotalRequiredCredits: ").Append(TotalRequiredCredits).Append("\n");
            sb.Append("  TotalRequiredCreditTypeDescriptor: ").Append(TotalRequiredCreditTypeDescriptor).Append("\n");
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
            return this.Equals(input as EdFiGraduationPlan);
        }

        /// <summary>
        /// Returns true if EdFiGraduationPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGraduationPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGraduationPlan input)
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
                    this.GraduationPlanTypeDescriptor == input.GraduationPlanTypeDescriptor ||
                    (this.GraduationPlanTypeDescriptor != null &&
                    this.GraduationPlanTypeDescriptor.Equals(input.GraduationPlanTypeDescriptor))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.GraduationSchoolYearTypeReference == input.GraduationSchoolYearTypeReference ||
                    (this.GraduationSchoolYearTypeReference != null &&
                    this.GraduationSchoolYearTypeReference.Equals(input.GraduationSchoolYearTypeReference))
                ) && 
                (
                    this.CreditsByCourses == input.CreditsByCourses ||
                    this.CreditsByCourses != null &&
                    this.CreditsByCourses.SequenceEqual(input.CreditsByCourses)
                ) && 
                (
                    this.CreditsByCreditCategories == input.CreditsByCreditCategories ||
                    this.CreditsByCreditCategories != null &&
                    this.CreditsByCreditCategories.SequenceEqual(input.CreditsByCreditCategories)
                ) && 
                (
                    this.CreditsBySubjects == input.CreditsBySubjects ||
                    this.CreditsBySubjects != null &&
                    this.CreditsBySubjects.SequenceEqual(input.CreditsBySubjects)
                ) && 
                (
                    this.IndividualPlan == input.IndividualPlan ||
                    (this.IndividualPlan != null &&
                    this.IndividualPlan.Equals(input.IndividualPlan))
                ) && 
                (
                    this.RequiredAssessments == input.RequiredAssessments ||
                    this.RequiredAssessments != null &&
                    this.RequiredAssessments.SequenceEqual(input.RequiredAssessments)
                ) && 
                (
                    this.TotalRequiredCreditConversion == input.TotalRequiredCreditConversion ||
                    (this.TotalRequiredCreditConversion != null &&
                    this.TotalRequiredCreditConversion.Equals(input.TotalRequiredCreditConversion))
                ) && 
                (
                    this.TotalRequiredCredits == input.TotalRequiredCredits ||
                    (this.TotalRequiredCredits != null &&
                    this.TotalRequiredCredits.Equals(input.TotalRequiredCredits))
                ) && 
                (
                    this.TotalRequiredCreditTypeDescriptor == input.TotalRequiredCreditTypeDescriptor ||
                    (this.TotalRequiredCreditTypeDescriptor != null &&
                    this.TotalRequiredCreditTypeDescriptor.Equals(input.TotalRequiredCreditTypeDescriptor))
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
                if (this.GraduationPlanTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.GraduationPlanTypeDescriptor.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.GraduationSchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.GraduationSchoolYearTypeReference.GetHashCode();
                if (this.CreditsByCourses != null)
                    hashCode = hashCode * 59 + this.CreditsByCourses.GetHashCode();
                if (this.CreditsByCreditCategories != null)
                    hashCode = hashCode * 59 + this.CreditsByCreditCategories.GetHashCode();
                if (this.CreditsBySubjects != null)
                    hashCode = hashCode * 59 + this.CreditsBySubjects.GetHashCode();
                if (this.IndividualPlan != null)
                    hashCode = hashCode * 59 + this.IndividualPlan.GetHashCode();
                if (this.RequiredAssessments != null)
                    hashCode = hashCode * 59 + this.RequiredAssessments.GetHashCode();
                if (this.TotalRequiredCreditConversion != null)
                    hashCode = hashCode * 59 + this.TotalRequiredCreditConversion.GetHashCode();
                if (this.TotalRequiredCredits != null)
                    hashCode = hashCode * 59 + this.TotalRequiredCredits.GetHashCode();
                if (this.TotalRequiredCreditTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.TotalRequiredCreditTypeDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
