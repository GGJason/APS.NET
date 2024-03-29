/*
 * APS API (Formly Forge API)
 *
 * APS API based on https://aps.autodesk.com
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = ApsNET.Client.OpenAPIDateConverter;

namespace ApsNET.Model
{
    /// <summary>
    /// Bearer
    /// </summary>
    [DataContract(Name = "Bearer")]
    public partial class Bearer : IEquatable<Bearer>, IValidatableObject
    {
        /// <summary>
        /// Defines TokenType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TokenTypeEnum
        {
            /// <summary>
            /// Enum Bearer for value: Bearer
            /// </summary>
            [EnumMember(Value = "Bearer")]
            Bearer = 1

        }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public TokenTypeEnum? TokenType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bearer" /> class.
        /// </summary>
        /// <param name="tokenType">tokenType.</param>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="expiresIn">expiresIn.</param>
        public Bearer(TokenTypeEnum? tokenType = default(TokenTypeEnum?), string accessToken = default(string), int expiresIn = default(int))
        {
            this.TokenType = tokenType;
            this.AccessToken = accessToken;
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bearer {\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
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
            return this.Equals(input as Bearer);
        }

        /// <summary>
        /// Returns true if Bearer instances are equal
        /// </summary>
        /// <param name="input">Instance of Bearer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bearer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenType == input.TokenType ||
                    this.TokenType.Equals(input.TokenType)
                ) && 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    this.ExpiresIn.Equals(input.ExpiresIn)
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
                hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
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
