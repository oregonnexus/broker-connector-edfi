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
    /// TpdmRecruitmentEvent
    /// </summary>
    [DataContract]
    public partial class TpdmRecruitmentEvent :  IEquatable<TpdmRecruitmentEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRecruitmentEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmRecruitmentEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmRecruitmentEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="eventDate">The date of the event. (required).</param>
        /// <param name="eventTitle">The title of the event. (required).</param>
        /// <param name="eventDescription">The long description of the event..</param>
        /// <param name="eventLocation">The location of the event..</param>
        /// <param name="recruitmentEventTypeDescriptor">The type of event. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmRecruitmentEvent(string id = default(string), DateTime? eventDate = default(DateTime?), string eventTitle = default(string), string eventDescription = default(string), string eventLocation = default(string), string recruitmentEventTypeDescriptor = default(string), string etag = default(string))
        {
            // to ensure "eventDate" is required (not null)
            if (eventDate == null)
            {
                throw new InvalidDataException("eventDate is a required property for TpdmRecruitmentEvent and cannot be null");
            }
            else
            {
                this.EventDate = eventDate;
            }
            // to ensure "eventTitle" is required (not null)
            if (eventTitle == null)
            {
                throw new InvalidDataException("eventTitle is a required property for TpdmRecruitmentEvent and cannot be null");
            }
            else
            {
                this.EventTitle = eventTitle;
            }
            // to ensure "recruitmentEventTypeDescriptor" is required (not null)
            if (recruitmentEventTypeDescriptor == null)
            {
                throw new InvalidDataException("recruitmentEventTypeDescriptor is a required property for TpdmRecruitmentEvent and cannot be null");
            }
            else
            {
                this.RecruitmentEventTypeDescriptor = recruitmentEventTypeDescriptor;
            }
            this.Id = id;
            this.EventDescription = eventDescription;
            this.EventLocation = eventLocation;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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
        /// The long description of the event.
        /// </summary>
        /// <value>The long description of the event.</value>
        [DataMember(Name="eventDescription", EmitDefaultValue=false)]
        public string EventDescription { get; set; }

        /// <summary>
        /// The location of the event.
        /// </summary>
        /// <value>The location of the event.</value>
        [DataMember(Name="eventLocation", EmitDefaultValue=false)]
        public string EventLocation { get; set; }

        /// <summary>
        /// The type of event.
        /// </summary>
        /// <value>The type of event.</value>
        [DataMember(Name="recruitmentEventTypeDescriptor", EmitDefaultValue=false)]
        public string RecruitmentEventTypeDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmRecruitmentEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EventTitle: ").Append(EventTitle).Append("\n");
            sb.Append("  EventDescription: ").Append(EventDescription).Append("\n");
            sb.Append("  EventLocation: ").Append(EventLocation).Append("\n");
            sb.Append("  RecruitmentEventTypeDescriptor: ").Append(RecruitmentEventTypeDescriptor).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as TpdmRecruitmentEvent);
        }

        /// <summary>
        /// Returns true if TpdmRecruitmentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmRecruitmentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmRecruitmentEvent input)
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
                    this.EventDescription == input.EventDescription ||
                    (this.EventDescription != null &&
                    this.EventDescription.Equals(input.EventDescription))
                ) && 
                (
                    this.EventLocation == input.EventLocation ||
                    (this.EventLocation != null &&
                    this.EventLocation.Equals(input.EventLocation))
                ) && 
                (
                    this.RecruitmentEventTypeDescriptor == input.RecruitmentEventTypeDescriptor ||
                    (this.RecruitmentEventTypeDescriptor != null &&
                    this.RecruitmentEventTypeDescriptor.Equals(input.RecruitmentEventTypeDescriptor))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.EventDate != null)
                    hashCode = hashCode * 59 + this.EventDate.GetHashCode();
                if (this.EventTitle != null)
                    hashCode = hashCode * 59 + this.EventTitle.GetHashCode();
                if (this.EventDescription != null)
                    hashCode = hashCode * 59 + this.EventDescription.GetHashCode();
                if (this.EventLocation != null)
                    hashCode = hashCode * 59 + this.EventLocation.GetHashCode();
                if (this.RecruitmentEventTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.RecruitmentEventTypeDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
