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
    /// WordPosition
    /// </summary>
    [DataContract]
    public partial class WordPosition :  IEquatable<WordPosition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WordPosition" /> class.
        /// </summary>
        /// <param name="word">Word as a string.</param>
        /// <param name="wordIndex">Zero-based index of the word; first word has index 0, second word has index 1 and so on.</param>
        /// <param name="startPosition">Zero-based character offset at which the word begins in the input string.</param>
        /// <param name="endPosition">Zero-based character offset at which the word ends in the input string.</param>
        public WordPosition(string word = default(string), int? wordIndex = default(int?), int? startPosition = default(int?), int? endPosition = default(int?))
        {
            this.Word = word;
            this.WordIndex = wordIndex;
            this.StartPosition = startPosition;
            this.EndPosition = endPosition;
        }
        
        /// <summary>
        /// Word as a string
        /// </summary>
        /// <value>Word as a string</value>
        [DataMember(Name="Word", EmitDefaultValue=false)]
        public string Word { get; set; }

        /// <summary>
        /// Zero-based index of the word; first word has index 0, second word has index 1 and so on
        /// </summary>
        /// <value>Zero-based index of the word; first word has index 0, second word has index 1 and so on</value>
        [DataMember(Name="WordIndex", EmitDefaultValue=false)]
        public int? WordIndex { get; set; }

        /// <summary>
        /// Zero-based character offset at which the word begins in the input string
        /// </summary>
        /// <value>Zero-based character offset at which the word begins in the input string</value>
        [DataMember(Name="StartPosition", EmitDefaultValue=false)]
        public int? StartPosition { get; set; }

        /// <summary>
        /// Zero-based character offset at which the word ends in the input string
        /// </summary>
        /// <value>Zero-based character offset at which the word ends in the input string</value>
        [DataMember(Name="EndPosition", EmitDefaultValue=false)]
        public int? EndPosition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WordPosition {\n");
            sb.Append("  Word: ").Append(Word).Append("\n");
            sb.Append("  WordIndex: ").Append(WordIndex).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
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
            return this.Equals(input as WordPosition);
        }

        /// <summary>
        /// Returns true if WordPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of WordPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WordPosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Word == input.Word ||
                    (this.Word != null &&
                    this.Word.Equals(input.Word))
                ) && 
                (
                    this.WordIndex == input.WordIndex ||
                    (this.WordIndex != null &&
                    this.WordIndex.Equals(input.WordIndex))
                ) && 
                (
                    this.StartPosition == input.StartPosition ||
                    (this.StartPosition != null &&
                    this.StartPosition.Equals(input.StartPosition))
                ) && 
                (
                    this.EndPosition == input.EndPosition ||
                    (this.EndPosition != null &&
                    this.EndPosition.Equals(input.EndPosition))
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
                if (this.Word != null)
                    hashCode = hashCode * 59 + this.Word.GetHashCode();
                if (this.WordIndex != null)
                    hashCode = hashCode * 59 + this.WordIndex.GetHashCode();
                if (this.StartPosition != null)
                    hashCode = hashCode * 59 + this.StartPosition.GetHashCode();
                if (this.EndPosition != null)
                    hashCode = hashCode * 59 + this.EndPosition.GetHashCode();
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
