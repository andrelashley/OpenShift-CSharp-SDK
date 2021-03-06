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
    /// EgressNetworkPolicyRule contains a single egress network policy rule
    /// </summary>
    public partial class Comgithubopenshiftapinetworkv1EgressNetworkPolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapinetworkv1EgressNetworkPolicyRule class.
        /// </summary>
        public Comgithubopenshiftapinetworkv1EgressNetworkPolicyRule() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapinetworkv1EgressNetworkPolicyRule class.
        /// </summary>
        public Comgithubopenshiftapinetworkv1EgressNetworkPolicyRule(Comgithubopenshiftapinetworkv1EgressNetworkPolicyPeer to, string type)
        {
            To = to;
            Type = type;
        }

        /// <summary>
        /// to is the target that traffic is allowed/denied to
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public Comgithubopenshiftapinetworkv1EgressNetworkPolicyPeer To { get; set; }

        /// <summary>
        /// type marks this as an "Allow" or "Deny" rule
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (To == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "To");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
