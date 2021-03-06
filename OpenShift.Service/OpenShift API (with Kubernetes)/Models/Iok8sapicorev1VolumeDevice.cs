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
    /// volumeDevice describes a mapping of a raw block device within a
    /// container.
    /// </summary>
    public partial class Iok8sapicorev1VolumeDevice
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1VolumeDevice class.
        /// </summary>
        public Iok8sapicorev1VolumeDevice() { }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1VolumeDevice class.
        /// </summary>
        public Iok8sapicorev1VolumeDevice(string devicePath, string name)
        {
            DevicePath = devicePath;
            Name = name;
        }

        /// <summary>
        /// devicePath is the path inside of the container that the device
        /// will be mapped to.
        /// </summary>
        [JsonProperty(PropertyName = "devicePath")]
        public string DevicePath { get; set; }

        /// <summary>
        /// name must match the name of a persistentVolumeClaim in the pod
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (DevicePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DevicePath");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
