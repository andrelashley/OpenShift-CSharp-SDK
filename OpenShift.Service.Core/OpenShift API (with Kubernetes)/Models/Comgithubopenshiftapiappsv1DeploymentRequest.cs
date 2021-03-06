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
    /// DeploymentRequest is a request to a deployment config for a new
    /// deployment.
    /// </summary>
    public partial class Comgithubopenshiftapiappsv1DeploymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiappsv1DeploymentRequest class.
        /// </summary>
        public Comgithubopenshiftapiappsv1DeploymentRequest() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiappsv1DeploymentRequest class.
        /// </summary>
        public Comgithubopenshiftapiappsv1DeploymentRequest(bool force, bool latest, string name, string apiVersion = default(string), IList<string> excludeTriggers = default(IList<string>), string kind = default(string))
        {
            ApiVersion = apiVersion;
            ExcludeTriggers = excludeTriggers;
            Force = force;
            Kind = kind;
            Latest = latest;
            Name = name;
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
        /// ExcludeTriggers instructs the instantiator to avoid processing the
        /// specified triggers. This field overrides the triggers from latest
        /// and allows clients to control specific logic. This field is
        /// ignored if not specified.
        /// </summary>
        [JsonProperty(PropertyName = "excludeTriggers")]
        public IList<string> ExcludeTriggers { get; set; }

        /// <summary>
        /// Force will try to force a new deployment to run. If the deployment
        /// config is paused, then setting this to true will return an
        /// Invalid error.
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool Force { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Latest will update the deployment config with the latest state
        /// from all triggers.
        /// </summary>
        [JsonProperty(PropertyName = "latest")]
        public bool Latest { get; set; }

        /// <summary>
        /// Name of the deployment config for requesting a new deployment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
