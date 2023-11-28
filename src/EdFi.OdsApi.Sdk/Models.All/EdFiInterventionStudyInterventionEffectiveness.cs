/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiInterventionStudyInterventionEffectiveness
    /// </summary>
    [DataContract(Name = "edFi_interventionStudyInterventionEffectiveness")]
    public partial class EdFiInterventionStudyInterventionEffectiveness : IEquatable<EdFiInterventionStudyInterventionEffectiveness>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudyInterventionEffectiveness" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionStudyInterventionEffectiveness() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudyInterventionEffectiveness" /> class.
        /// </summary>
        /// <param name="diagnosisDescriptor">Targeted purpose of the intervention (e.g., attendance issue, dropout risk) for which the effectiveness is measured. (required).</param>
        /// <param name="gradeLevelDescriptor">Grade level for which effectiveness is measured. (required).</param>
        /// <param name="populationServedDescriptor">Population for which effectiveness is measured. (required).</param>
        /// <param name="interventionEffectivenessRatingDescriptor">An intervention demonstrates effectiveness if the research has shown that the program caused an improvement in outcomes. Values: positive effects, potentially positive effects, mixed effects, potentially negative effects, negative effects, and no discernible effects. (required).</param>
        /// <param name="improvementIndex">Along a percentile distribution of students, the improvement index represents the change in an average student&#39;s percentile rank that is considered to be due to the intervention..</param>
        public EdFiInterventionStudyInterventionEffectiveness(string diagnosisDescriptor = default(string), string gradeLevelDescriptor = default(string), string populationServedDescriptor = default(string), string interventionEffectivenessRatingDescriptor = default(string), int? improvementIndex = default(int?))
        {
            // to ensure "diagnosisDescriptor" is required (not null)
            if (diagnosisDescriptor == null)
            {
                throw new ArgumentNullException("diagnosisDescriptor is a required property for EdFiInterventionStudyInterventionEffectiveness and cannot be null");
            }
            this.DiagnosisDescriptor = diagnosisDescriptor;
            // to ensure "gradeLevelDescriptor" is required (not null)
            if (gradeLevelDescriptor == null)
            {
                throw new ArgumentNullException("gradeLevelDescriptor is a required property for EdFiInterventionStudyInterventionEffectiveness and cannot be null");
            }
            this.GradeLevelDescriptor = gradeLevelDescriptor;
            // to ensure "populationServedDescriptor" is required (not null)
            if (populationServedDescriptor == null)
            {
                throw new ArgumentNullException("populationServedDescriptor is a required property for EdFiInterventionStudyInterventionEffectiveness and cannot be null");
            }
            this.PopulationServedDescriptor = populationServedDescriptor;
            // to ensure "interventionEffectivenessRatingDescriptor" is required (not null)
            if (interventionEffectivenessRatingDescriptor == null)
            {
                throw new ArgumentNullException("interventionEffectivenessRatingDescriptor is a required property for EdFiInterventionStudyInterventionEffectiveness and cannot be null");
            }
            this.InterventionEffectivenessRatingDescriptor = interventionEffectivenessRatingDescriptor;
            this.ImprovementIndex = improvementIndex;
        }

        /// <summary>
        /// Targeted purpose of the intervention (e.g., attendance issue, dropout risk) for which the effectiveness is measured.
        /// </summary>
        /// <value>Targeted purpose of the intervention (e.g., attendance issue, dropout risk) for which the effectiveness is measured.</value>
        [DataMember(Name = "diagnosisDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string DiagnosisDescriptor { get; set; }

        /// <summary>
        /// Grade level for which effectiveness is measured.
        /// </summary>
        /// <value>Grade level for which effectiveness is measured.</value>
        [DataMember(Name = "gradeLevelDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string GradeLevelDescriptor { get; set; }

        /// <summary>
        /// Population for which effectiveness is measured.
        /// </summary>
        /// <value>Population for which effectiveness is measured.</value>
        [DataMember(Name = "populationServedDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string PopulationServedDescriptor { get; set; }

        /// <summary>
        /// An intervention demonstrates effectiveness if the research has shown that the program caused an improvement in outcomes. Values: positive effects, potentially positive effects, mixed effects, potentially negative effects, negative effects, and no discernible effects.
        /// </summary>
        /// <value>An intervention demonstrates effectiveness if the research has shown that the program caused an improvement in outcomes. Values: positive effects, potentially positive effects, mixed effects, potentially negative effects, negative effects, and no discernible effects.</value>
        [DataMember(Name = "interventionEffectivenessRatingDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string InterventionEffectivenessRatingDescriptor { get; set; }

        /// <summary>
        /// Along a percentile distribution of students, the improvement index represents the change in an average student&#39;s percentile rank that is considered to be due to the intervention.
        /// </summary>
        /// <value>Along a percentile distribution of students, the improvement index represents the change in an average student&#39;s percentile rank that is considered to be due to the intervention.</value>
        [DataMember(Name = "improvementIndex", EmitDefaultValue = true)]
        public int? ImprovementIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiInterventionStudyInterventionEffectiveness {\n");
            sb.Append("  DiagnosisDescriptor: ").Append(DiagnosisDescriptor).Append("\n");
            sb.Append("  GradeLevelDescriptor: ").Append(GradeLevelDescriptor).Append("\n");
            sb.Append("  PopulationServedDescriptor: ").Append(PopulationServedDescriptor).Append("\n");
            sb.Append("  InterventionEffectivenessRatingDescriptor: ").Append(InterventionEffectivenessRatingDescriptor).Append("\n");
            sb.Append("  ImprovementIndex: ").Append(ImprovementIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiInterventionStudyInterventionEffectiveness);
        }

        /// <summary>
        /// Returns true if EdFiInterventionStudyInterventionEffectiveness instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionStudyInterventionEffectiveness to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionStudyInterventionEffectiveness input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiagnosisDescriptor == input.DiagnosisDescriptor ||
                    (this.DiagnosisDescriptor != null &&
                    this.DiagnosisDescriptor.Equals(input.DiagnosisDescriptor))
                ) && 
                (
                    this.GradeLevelDescriptor == input.GradeLevelDescriptor ||
                    (this.GradeLevelDescriptor != null &&
                    this.GradeLevelDescriptor.Equals(input.GradeLevelDescriptor))
                ) && 
                (
                    this.PopulationServedDescriptor == input.PopulationServedDescriptor ||
                    (this.PopulationServedDescriptor != null &&
                    this.PopulationServedDescriptor.Equals(input.PopulationServedDescriptor))
                ) && 
                (
                    this.InterventionEffectivenessRatingDescriptor == input.InterventionEffectivenessRatingDescriptor ||
                    (this.InterventionEffectivenessRatingDescriptor != null &&
                    this.InterventionEffectivenessRatingDescriptor.Equals(input.InterventionEffectivenessRatingDescriptor))
                ) && 
                (
                    this.ImprovementIndex == input.ImprovementIndex ||
                    (this.ImprovementIndex != null &&
                    this.ImprovementIndex.Equals(input.ImprovementIndex))
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
                if (this.DiagnosisDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.DiagnosisDescriptor.GetHashCode();
                }
                if (this.GradeLevelDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.GradeLevelDescriptor.GetHashCode();
                }
                if (this.PopulationServedDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.PopulationServedDescriptor.GetHashCode();
                }
                if (this.InterventionEffectivenessRatingDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.InterventionEffectivenessRatingDescriptor.GetHashCode();
                }
                if (this.ImprovementIndex != null)
                {
                    hashCode = (hashCode * 59) + this.ImprovementIndex.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // DiagnosisDescriptor (string) maxLength
            if (this.DiagnosisDescriptor != null && this.DiagnosisDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiagnosisDescriptor, length must be less than 306.", new [] { "DiagnosisDescriptor" });
            }

            // GradeLevelDescriptor (string) maxLength
            if (this.GradeLevelDescriptor != null && this.GradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradeLevelDescriptor, length must be less than 306.", new [] { "GradeLevelDescriptor" });
            }

            // PopulationServedDescriptor (string) maxLength
            if (this.PopulationServedDescriptor != null && this.PopulationServedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PopulationServedDescriptor, length must be less than 306.", new [] { "PopulationServedDescriptor" });
            }

            // InterventionEffectivenessRatingDescriptor (string) maxLength
            if (this.InterventionEffectivenessRatingDescriptor != null && this.InterventionEffectivenessRatingDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InterventionEffectivenessRatingDescriptor, length must be less than 306.", new [] { "InterventionEffectivenessRatingDescriptor" });
            }

            yield break;
        }
    }

}
