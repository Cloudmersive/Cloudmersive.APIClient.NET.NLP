/* 
 * nlpapiv2
 *
 * The powerful Natural Language Processing APIs (v2) let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
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
    /// Output of a language translation operation
    /// </summary>
    [DataContract]
    public partial class LanguageTranslationResponse :  IEquatable<LanguageTranslationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageTranslationResponse" /> class.
        /// </summary>
        /// <param name="successful">True if the language detection operation was successful, false otherwise.</param>
        /// <param name="translatedTextResult">Translated text in target language.</param>
        /// <param name="sentenceCount">Number of sentences in input text.</param>
        public LanguageTranslationResponse(bool? successful = default(bool?), string translatedTextResult = default(string), int? sentenceCount = default(int?))
        {
            this.Successful = successful;
            this.TranslatedTextResult = translatedTextResult;
            this.SentenceCount = sentenceCount;
        }
        
        /// <summary>
        /// True if the language detection operation was successful, false otherwise
        /// </summary>
        /// <value>True if the language detection operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Translated text in target language
        /// </summary>
        /// <value>Translated text in target language</value>
        [DataMember(Name="TranslatedTextResult", EmitDefaultValue=false)]
        public string TranslatedTextResult { get; set; }

        /// <summary>
        /// Number of sentences in input text
        /// </summary>
        /// <value>Number of sentences in input text</value>
        [DataMember(Name="SentenceCount", EmitDefaultValue=false)]
        public int? SentenceCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageTranslationResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  TranslatedTextResult: ").Append(TranslatedTextResult).Append("\n");
            sb.Append("  SentenceCount: ").Append(SentenceCount).Append("\n");
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
            return this.Equals(input as LanguageTranslationResponse);
        }

        /// <summary>
        /// Returns true if LanguageTranslationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LanguageTranslationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageTranslationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.TranslatedTextResult == input.TranslatedTextResult ||
                    (this.TranslatedTextResult != null &&
                    this.TranslatedTextResult.Equals(input.TranslatedTextResult))
                ) && 
                (
                    this.SentenceCount == input.SentenceCount ||
                    (this.SentenceCount != null &&
                    this.SentenceCount.Equals(input.SentenceCount))
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.TranslatedTextResult != null)
                    hashCode = hashCode * 59 + this.TranslatedTextResult.GetHashCode();
                if (this.SentenceCount != null)
                    hashCode = hashCode * 59 + this.SentenceCount.GetHashCode();
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
