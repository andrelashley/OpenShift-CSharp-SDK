﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace OpenShift.Service.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// SelfSubjectRulesReviewSpec adds information about how to conduct the
    /// check
    /// </summary>
    public partial class Comgithubopenshiftapiauthorizationv1SelfSubjectRulesReviewSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiauthorizationv1SelfSubjectRulesReviewSpec
        /// class.
        /// </summary>
        public Comgithubopenshiftapiauthorizationv1SelfSubjectRulesReviewSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiauthorizationv1SelfSubjectRulesReviewSpec
        /// class.
        /// </summary>
        public Comgithubopenshiftapiauthorizationv1SelfSubjectRulesReviewSpec(IList<string> scopes)
        {
            Scopes = scopes;
        }

        /// <summary>
        /// Scopes to use for the evaluation.  Empty means "use the unscoped
        /// (full) permissions of the user/groups". Nil means "use the scopes
        /// on this request".
        /// </summary>
        [JsonProperty(PropertyName = "scopes")]
        public IList<string> Scopes { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Scopes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scopes");
            }
        }
    }
}