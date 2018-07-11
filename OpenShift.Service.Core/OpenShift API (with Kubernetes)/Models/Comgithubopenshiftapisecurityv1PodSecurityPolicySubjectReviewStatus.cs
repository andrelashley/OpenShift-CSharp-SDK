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
    /// PodSecurityPolicySubjectReviewStatus contains information/status for
    /// PodSecurityPolicySubjectReview.
    /// </summary>
    public partial class Comgithubopenshiftapisecurityv1PodSecurityPolicySubjectReviewStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapisecurityv1PodSecurityPolicySubjectReviewStatus
        /// class.
        /// </summary>
        public Comgithubopenshiftapisecurityv1PodSecurityPolicySubjectReviewStatus() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapisecurityv1PodSecurityPolicySubjectReviewStatus
        /// class.
        /// </summary>
        public Comgithubopenshiftapisecurityv1PodSecurityPolicySubjectReviewStatus(Iok8sapicorev1ObjectReference allowedBy = default(Iok8sapicorev1ObjectReference), string reason = default(string), Iok8sapicorev1PodTemplateSpec template = default(Iok8sapicorev1PodTemplateSpec))
        {
            AllowedBy = allowedBy;
            Reason = reason;
            Template = template;
        }

        /// <summary>
        /// allowedBy is a reference to the rule that allows the
        /// PodTemplateSpec. A rule can be a SecurityContextConstraint or a
        /// PodSecurityPolicy A `nil`, indicates that it was denied.
        /// </summary>
        [JsonProperty(PropertyName = "allowedBy")]
        public Iok8sapicorev1ObjectReference AllowedBy { get; set; }

        /// <summary>
        /// A machine-readable description of why this operation is in the
        /// "Failure" status. If this value is empty there is no information
        /// available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// template is the PodTemplateSpec after the defaulting is applied.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public Iok8sapicorev1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Template != null)
            {
                this.Template.Validate();
            }
        }
    }
}