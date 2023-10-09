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
    /// SampleBusRouteStartTime
    /// </summary>
    [DataContract]
    public partial class SampleBusRouteStartTime :  IEquatable<SampleBusRouteStartTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleBusRouteStartTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleBusRouteStartTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleBusRouteStartTime" /> class.
        /// </summary>
        /// <param name="startTime">The time the bus route begins. (required).</param>
        public SampleBusRouteStartTime(string startTime = default(string))
        {
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new InvalidDataException("startTime is a required property for SampleBusRouteStartTime and cannot be null");
            }
            else
            {
                this.StartTime = startTime;
            }
        }
        
        /// <summary>
        /// The time the bus route begins.
        /// </summary>
        /// <value>The time the bus route begins.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleBusRouteStartTime {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as SampleBusRouteStartTime);
        }

        /// <summary>
        /// Returns true if SampleBusRouteStartTime instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleBusRouteStartTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleBusRouteStartTime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }

}
