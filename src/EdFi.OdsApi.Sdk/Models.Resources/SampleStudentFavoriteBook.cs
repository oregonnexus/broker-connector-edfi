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
    /// SampleStudentFavoriteBook
    /// </summary>
    [DataContract]
    public partial class SampleStudentFavoriteBook :  IEquatable<SampleStudentFavoriteBook>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentFavoriteBook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentFavoriteBook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentFavoriteBook" /> class.
        /// </summary>
        /// <param name="favoriteBookCategoryDescriptor">This is documentation. (required).</param>
        /// <param name="bookTitle">This is documentation..</param>
        /// <param name="artMedia">An unordered collection of studentFavoriteBookArtMedia. This is documentation..</param>
        public SampleStudentFavoriteBook(string favoriteBookCategoryDescriptor = default(string), string bookTitle = default(string), List<SampleStudentFavoriteBookArtMedium> artMedia = default(List<SampleStudentFavoriteBookArtMedium>))
        {
            // to ensure "favoriteBookCategoryDescriptor" is required (not null)
            if (favoriteBookCategoryDescriptor == null)
            {
                throw new InvalidDataException("favoriteBookCategoryDescriptor is a required property for SampleStudentFavoriteBook and cannot be null");
            }
            else
            {
                this.FavoriteBookCategoryDescriptor = favoriteBookCategoryDescriptor;
            }
            this.BookTitle = bookTitle;
            this.ArtMedia = artMedia;
        }
        
        /// <summary>
        /// This is documentation.
        /// </summary>
        /// <value>This is documentation.</value>
        [DataMember(Name="favoriteBookCategoryDescriptor", EmitDefaultValue=false)]
        public string FavoriteBookCategoryDescriptor { get; set; }

        /// <summary>
        /// This is documentation.
        /// </summary>
        /// <value>This is documentation.</value>
        [DataMember(Name="bookTitle", EmitDefaultValue=false)]
        public string BookTitle { get; set; }

        /// <summary>
        /// An unordered collection of studentFavoriteBookArtMedia. This is documentation.
        /// </summary>
        /// <value>An unordered collection of studentFavoriteBookArtMedia. This is documentation.</value>
        [DataMember(Name="artMedia", EmitDefaultValue=false)]
        public List<SampleStudentFavoriteBookArtMedium> ArtMedia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleStudentFavoriteBook {\n");
            sb.Append("  FavoriteBookCategoryDescriptor: ").Append(FavoriteBookCategoryDescriptor).Append("\n");
            sb.Append("  BookTitle: ").Append(BookTitle).Append("\n");
            sb.Append("  ArtMedia: ").Append(ArtMedia).Append("\n");
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
            return this.Equals(input as SampleStudentFavoriteBook);
        }

        /// <summary>
        /// Returns true if SampleStudentFavoriteBook instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentFavoriteBook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentFavoriteBook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FavoriteBookCategoryDescriptor == input.FavoriteBookCategoryDescriptor ||
                    (this.FavoriteBookCategoryDescriptor != null &&
                    this.FavoriteBookCategoryDescriptor.Equals(input.FavoriteBookCategoryDescriptor))
                ) && 
                (
                    this.BookTitle == input.BookTitle ||
                    (this.BookTitle != null &&
                    this.BookTitle.Equals(input.BookTitle))
                ) && 
                (
                    this.ArtMedia == input.ArtMedia ||
                    this.ArtMedia != null &&
                    this.ArtMedia.SequenceEqual(input.ArtMedia)
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
                if (this.FavoriteBookCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.FavoriteBookCategoryDescriptor.GetHashCode();
                if (this.BookTitle != null)
                    hashCode = hashCode * 59 + this.BookTitle.GetHashCode();
                if (this.ArtMedia != null)
                    hashCode = hashCode * 59 + this.ArtMedia.GetHashCode();
                return hashCode;
            }
        }
    }

}
