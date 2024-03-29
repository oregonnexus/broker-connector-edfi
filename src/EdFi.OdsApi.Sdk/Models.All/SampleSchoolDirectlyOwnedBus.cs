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
    /// SampleSchoolDirectlyOwnedBus
    /// </summary>
    [DataContract(Name = "sample_schoolDirectlyOwnedBus")]
    public partial class SampleSchoolDirectlyOwnedBus : IEquatable<SampleSchoolDirectlyOwnedBus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleSchoolDirectlyOwnedBus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleSchoolDirectlyOwnedBus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleSchoolDirectlyOwnedBus" /> class.
        /// </summary>
        /// <param name="directlyOwnedBusReference">directlyOwnedBusReference (required).</param>
        public SampleSchoolDirectlyOwnedBus(SampleBusReference directlyOwnedBusReference = default(SampleBusReference))
        {
            // to ensure "directlyOwnedBusReference" is required (not null)
            if (directlyOwnedBusReference == null)
            {
                throw new ArgumentNullException("directlyOwnedBusReference is a required property for SampleSchoolDirectlyOwnedBus and cannot be null");
            }
            this.DirectlyOwnedBusReference = directlyOwnedBusReference;
        }

        /// <summary>
        /// Gets or Sets DirectlyOwnedBusReference
        /// </summary>
        [DataMember(Name = "directlyOwnedBusReference", IsRequired = true, EmitDefaultValue = true)]
        public SampleBusReference DirectlyOwnedBusReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SampleSchoolDirectlyOwnedBus {\n");
            sb.Append("  DirectlyOwnedBusReference: ").Append(DirectlyOwnedBusReference).Append("\n");
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
            return this.Equals(input as SampleSchoolDirectlyOwnedBus);
        }

        /// <summary>
        /// Returns true if SampleSchoolDirectlyOwnedBus instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleSchoolDirectlyOwnedBus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleSchoolDirectlyOwnedBus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DirectlyOwnedBusReference == input.DirectlyOwnedBusReference ||
                    (this.DirectlyOwnedBusReference != null &&
                    this.DirectlyOwnedBusReference.Equals(input.DirectlyOwnedBusReference))
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
                if (this.DirectlyOwnedBusReference != null)
                {
                    hashCode = (hashCode * 59) + this.DirectlyOwnedBusReference.GetHashCode();
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
            yield break;
        }
    }

}
