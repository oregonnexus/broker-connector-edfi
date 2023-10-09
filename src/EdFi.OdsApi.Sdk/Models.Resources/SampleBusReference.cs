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
    /// SampleBusReference
    /// </summary>
    [DataContract]
    public partial class SampleBusReference :  IEquatable<SampleBusReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleBusReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleBusReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleBusReference" /> class.
        /// </summary>
        /// <param name="busId">The unique identifier for the bus. (required).</param>
        /// <param name="link">link.</param>
        public SampleBusReference(string busId = default(string), Link link = default(Link))
        {
            // to ensure "busId" is required (not null)
            if (busId == null)
            {
                throw new InvalidDataException("busId is a required property for SampleBusReference and cannot be null");
            }
            else
            {
                this.BusId = busId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The unique identifier for the bus.
        /// </summary>
        /// <value>The unique identifier for the bus.</value>
        [DataMember(Name="busId", EmitDefaultValue=false)]
        public string BusId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleBusReference {\n");
            sb.Append("  BusId: ").Append(BusId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as SampleBusReference);
        }

        /// <summary>
        /// Returns true if SampleBusReference instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleBusReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleBusReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusId == input.BusId ||
                    (this.BusId != null &&
                    this.BusId.Equals(input.BusId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.BusId != null)
                    hashCode = hashCode * 59 + this.BusId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
