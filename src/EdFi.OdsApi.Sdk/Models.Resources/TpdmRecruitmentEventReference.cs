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
    /// TpdmRecruitmentEventReference
    /// </summary>
    [DataContract]
    public partial class TpdmRecruitmentEventReference :  IEquatable<TpdmRecruitmentEventReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRecruitmentEventReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmRecruitmentEventReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRecruitmentEventReference" /> class.
        /// </summary>
        /// <param name="eventDate">The date of the event. (required).</param>
        /// <param name="eventTitle">The title of the event. (required).</param>
        /// <param name="link">link.</param>
        public TpdmRecruitmentEventReference(DateTime? eventDate = default(DateTime?), string eventTitle = default(string), Link link = default(Link))
        {
            // to ensure "eventDate" is required (not null)
            if (eventDate == null)
            {
                throw new InvalidDataException("eventDate is a required property for TpdmRecruitmentEventReference and cannot be null");
            }
            else
            {
                this.EventDate = eventDate;
            }
            // to ensure "eventTitle" is required (not null)
            if (eventTitle == null)
            {
                throw new InvalidDataException("eventTitle is a required property for TpdmRecruitmentEventReference and cannot be null");
            }
            else
            {
                this.EventTitle = eventTitle;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The date of the event.
        /// </summary>
        /// <value>The date of the event.</value>
        [DataMember(Name="eventDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// The title of the event.
        /// </summary>
        /// <value>The title of the event.</value>
        [DataMember(Name="eventTitle", EmitDefaultValue=false)]
        public string EventTitle { get; set; }

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
            sb.Append("class TpdmRecruitmentEventReference {\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EventTitle: ").Append(EventTitle).Append("\n");
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
            return this.Equals(input as TpdmRecruitmentEventReference);
        }

        /// <summary>
        /// Returns true if TpdmRecruitmentEventReference instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmRecruitmentEventReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmRecruitmentEventReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.EventTitle == input.EventTitle ||
                    (this.EventTitle != null &&
                    this.EventTitle.Equals(input.EventTitle))
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
                if (this.EventDate != null)
                    hashCode = hashCode * 59 + this.EventDate.GetHashCode();
                if (this.EventTitle != null)
                    hashCode = hashCode * 59 + this.EventTitle.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
