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
    /// DEPRECATED. DeploymentRollback stores the information required to
    /// rollback a deployment.
    /// </summary>
    public partial class Iok8sapiappsv1beta1DeploymentRollback
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta1DeploymentRollback class.
        /// </summary>
        public Iok8sapiappsv1beta1DeploymentRollback() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta1DeploymentRollback class.
        /// </summary>
        public Iok8sapiappsv1beta1DeploymentRollback(string name, Iok8sapiappsv1beta1RollbackConfig rollbackTo, string apiVersion = default(string), string kind = default(string), IDictionary<string, string> updatedAnnotations = default(IDictionary<string, string>))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Name = name;
            RollbackTo = rollbackTo;
            UpdatedAnnotations = updatedAnnotations;
        }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of
        /// an object. Servers should convert recognized schemas to the
        /// latest internal value, and may reject unrecognized values. More
        /// info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Required: This must match the Name of a deployment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The config of this deployment rollback.
        /// </summary>
        [JsonProperty(PropertyName = "rollbackTo")]
        public Iok8sapiappsv1beta1RollbackConfig RollbackTo { get; set; }

        /// <summary>
        /// The annotations to be updated to a deployment
        /// </summary>
        [JsonProperty(PropertyName = "updatedAnnotations")]
        public IDictionary<string, string> UpdatedAnnotations { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (RollbackTo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RollbackTo");
            }
        }
    }
}