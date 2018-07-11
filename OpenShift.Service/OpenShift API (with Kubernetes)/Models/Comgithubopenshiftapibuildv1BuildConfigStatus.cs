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
    /// BuildConfigStatus contains current state of the build config object.
    /// </summary>
    public partial class Comgithubopenshiftapibuildv1BuildConfigStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1BuildConfigStatus class.
        /// </summary>
        public Comgithubopenshiftapibuildv1BuildConfigStatus() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1BuildConfigStatus class.
        /// </summary>
        public Comgithubopenshiftapibuildv1BuildConfigStatus(long lastVersion)
        {
            LastVersion = lastVersion;
        }

        /// <summary>
        /// lastVersion is used to inform about number of last triggered build.
        /// </summary>
        [JsonProperty(PropertyName = "lastVersion")]
        public long LastVersion { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}