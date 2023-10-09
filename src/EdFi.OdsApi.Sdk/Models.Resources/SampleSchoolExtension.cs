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
    /// SampleSchoolExtension
    /// </summary>
    [DataContract]
    public partial class SampleSchoolExtension :  IEquatable<SampleSchoolExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleSchoolExtension" /> class.
        /// </summary>
        /// <param name="isExemplary">An indication as to whether the school is exemplary..</param>
        /// <param name="directlyOwnedBuses">An unordered collection of schoolDirectlyOwnedBuses. Buses owned by the School directly..</param>
        /// <param name="cteProgram">cteProgram.</param>
        public SampleSchoolExtension(bool? isExemplary = default(bool?), List<SampleSchoolDirectlyOwnedBus> directlyOwnedBuses = default(List<SampleSchoolDirectlyOwnedBus>), SampleSchoolCTEProgram cteProgram = default(SampleSchoolCTEProgram))
        {
            this.IsExemplary = isExemplary;
            this.DirectlyOwnedBuses = directlyOwnedBuses;
            this.CteProgram = cteProgram;
        }
        
        /// <summary>
        /// An indication as to whether the school is exemplary.
        /// </summary>
        /// <value>An indication as to whether the school is exemplary.</value>
        [DataMember(Name="isExemplary", EmitDefaultValue=false)]
        public bool? IsExemplary { get; set; }

        /// <summary>
        /// An unordered collection of schoolDirectlyOwnedBuses. Buses owned by the School directly.
        /// </summary>
        /// <value>An unordered collection of schoolDirectlyOwnedBuses. Buses owned by the School directly.</value>
        [DataMember(Name="directlyOwnedBuses", EmitDefaultValue=false)]
        public List<SampleSchoolDirectlyOwnedBus> DirectlyOwnedBuses { get; set; }

        /// <summary>
        /// Gets or Sets CteProgram
        /// </summary>
        [DataMember(Name="cteProgram", EmitDefaultValue=false)]
        public SampleSchoolCTEProgram CteProgram { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleSchoolExtension {\n");
            sb.Append("  IsExemplary: ").Append(IsExemplary).Append("\n");
            sb.Append("  DirectlyOwnedBuses: ").Append(DirectlyOwnedBuses).Append("\n");
            sb.Append("  CteProgram: ").Append(CteProgram).Append("\n");
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
            return this.Equals(input as SampleSchoolExtension);
        }

        /// <summary>
        /// Returns true if SampleSchoolExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleSchoolExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleSchoolExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsExemplary == input.IsExemplary ||
                    (this.IsExemplary != null &&
                    this.IsExemplary.Equals(input.IsExemplary))
                ) && 
                (
                    this.DirectlyOwnedBuses == input.DirectlyOwnedBuses ||
                    this.DirectlyOwnedBuses != null &&
                    this.DirectlyOwnedBuses.SequenceEqual(input.DirectlyOwnedBuses)
                ) && 
                (
                    this.CteProgram == input.CteProgram ||
                    (this.CteProgram != null &&
                    this.CteProgram.Equals(input.CteProgram))
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
                if (this.IsExemplary != null)
                    hashCode = hashCode * 59 + this.IsExemplary.GetHashCode();
                if (this.DirectlyOwnedBuses != null)
                    hashCode = hashCode * 59 + this.DirectlyOwnedBuses.GetHashCode();
                if (this.CteProgram != null)
                    hashCode = hashCode * 59 + this.CteProgram.GetHashCode();
                return hashCode;
            }
        }
    }

}
