/* 
 * nlpapi
 *
 * The powerful Natural Language Processing APIs let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NET.NLP.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.NLP.Model
{
    /// <summary>
    /// Result of spell checking a sentence
    /// </summary>
    [DataContract]
    public partial class CheckSentenceJsonResponse :  IEquatable<CheckSentenceJsonResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSentenceJsonResponse" /> class.
        /// </summary>
        /// <param name="IncorrectCount">Number of incorrect words.</param>
        /// <param name="Words">Words in the sentence, both correct and incorrect.</param>
        public CheckSentenceJsonResponse(int? IncorrectCount = default(int?), List<CorrectWordInSentenceJsonResponse> Words = default(List<CorrectWordInSentenceJsonResponse>))
        {
            this.IncorrectCount = IncorrectCount;
            this.Words = Words;
        }
        
        /// <summary>
        /// Number of incorrect words
        /// </summary>
        /// <value>Number of incorrect words</value>
        [DataMember(Name="IncorrectCount", EmitDefaultValue=false)]
        public int? IncorrectCount { get; set; }

        /// <summary>
        /// Words in the sentence, both correct and incorrect
        /// </summary>
        /// <value>Words in the sentence, both correct and incorrect</value>
        [DataMember(Name="Words", EmitDefaultValue=false)]
        public List<CorrectWordInSentenceJsonResponse> Words { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckSentenceJsonResponse {\n");
            sb.Append("  IncorrectCount: ").Append(IncorrectCount).Append("\n");
            sb.Append("  Words: ").Append(Words).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as CheckSentenceJsonResponse);
        }

        /// <summary>
        /// Returns true if CheckSentenceJsonResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckSentenceJsonResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckSentenceJsonResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncorrectCount == input.IncorrectCount ||
                    (this.IncorrectCount != null &&
                    this.IncorrectCount.Equals(input.IncorrectCount))
                ) && 
                (
                    this.Words == input.Words ||
                    this.Words != null &&
                    this.Words.SequenceEqual(input.Words)
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
                if (this.IncorrectCount != null)
                    hashCode = hashCode * 59 + this.IncorrectCount.GetHashCode();
                if (this.Words != null)
                    hashCode = hashCode * 59 + this.Words.GetHashCode();
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
