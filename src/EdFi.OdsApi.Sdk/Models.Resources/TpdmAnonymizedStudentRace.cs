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
    /// TpdmAnonymizedStudentRace
    /// </summary>
    [DataContract]
    public partial class TpdmAnonymizedStudentRace :  IEquatable<TpdmAnonymizedStudentRace>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmAnonymizedStudentRace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmAnonymizedStudentRace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmAnonymizedStudentRace" /> class.
        /// </summary>
        /// <param name="raceDescriptor">The general racial category which most clearly reflects the individual&#39;s                     recognition of his or her community or with which the individual most                     identifies. The data model allows for multiple entries so that each individual                     can specify all appropriate races. (required).</param>
        public TpdmAnonymizedStudentRace(string raceDescriptor = default(string))
        {
            // to ensure "raceDescriptor" is required (not null)
            if (raceDescriptor == null)
            {
                throw new InvalidDataException("raceDescriptor is a required property for TpdmAnonymizedStudentRace and cannot be null");
            }
            else
            {
                this.RaceDescriptor = raceDescriptor;
            }
        }
        
        /// <summary>
        /// The general racial category which most clearly reflects the individual&#39;s                     recognition of his or her community or with which the individual most                     identifies. The data model allows for multiple entries so that each individual                     can specify all appropriate races.
        /// </summary>
        /// <value>The general racial category which most clearly reflects the individual&#39;s                     recognition of his or her community or with which the individual most                     identifies. The data model allows for multiple entries so that each individual                     can specify all appropriate races.</value>
        [DataMember(Name="raceDescriptor", EmitDefaultValue=false)]
        public string RaceDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmAnonymizedStudentRace {\n");
            sb.Append("  RaceDescriptor: ").Append(RaceDescriptor).Append("\n");
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
            return this.Equals(input as TpdmAnonymizedStudentRace);
        }

        /// <summary>
        /// Returns true if TpdmAnonymizedStudentRace instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmAnonymizedStudentRace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmAnonymizedStudentRace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RaceDescriptor == input.RaceDescriptor ||
                    (this.RaceDescriptor != null &&
                    this.RaceDescriptor.Equals(input.RaceDescriptor))
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
                if (this.RaceDescriptor != null)
                    hashCode = hashCode * 59 + this.RaceDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
