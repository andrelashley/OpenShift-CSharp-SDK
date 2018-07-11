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
    /// BuildTriggerCause holds information about a triggered build. It is
    /// used for displaying build trigger data for each build and build
    /// configuration in oc describe. It is also used to describe which
    /// triggers led to the most recent update in the build configuration.
    /// </summary>
    public partial class Comgithubopenshiftapibuildv1BuildTriggerCause
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1BuildTriggerCause class.
        /// </summary>
        public Comgithubopenshiftapibuildv1BuildTriggerCause() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1BuildTriggerCause class.
        /// </summary>
        public Comgithubopenshiftapibuildv1BuildTriggerCause(Comgithubopenshiftapibuildv1BitbucketWebHookCause bitbucketWebHook = default(Comgithubopenshiftapibuildv1BitbucketWebHookCause), Comgithubopenshiftapibuildv1GenericWebHookCause genericWebHook = default(Comgithubopenshiftapibuildv1GenericWebHookCause), Comgithubopenshiftapibuildv1GitHubWebHookCause githubWebHook = default(Comgithubopenshiftapibuildv1GitHubWebHookCause), Comgithubopenshiftapibuildv1GitLabWebHookCause gitlabWebHook = default(Comgithubopenshiftapibuildv1GitLabWebHookCause), Comgithubopenshiftapibuildv1ImageChangeCause imageChangeBuild = default(Comgithubopenshiftapibuildv1ImageChangeCause), string message = default(string))
        {
            BitbucketWebHook = bitbucketWebHook;
            GenericWebHook = genericWebHook;
            GithubWebHook = githubWebHook;
            GitlabWebHook = gitlabWebHook;
            ImageChangeBuild = imageChangeBuild;
            Message = message;
        }

        /// <summary>
        /// BitbucketWebHook represents data for a Bitbucket webhook that
        /// fired a specific build.
        /// </summary>
        [JsonProperty(PropertyName = "bitbucketWebHook")]
        public Comgithubopenshiftapibuildv1BitbucketWebHookCause BitbucketWebHook { get; set; }

        /// <summary>
        /// genericWebHook holds data about a builds generic webhook trigger.
        /// </summary>
        [JsonProperty(PropertyName = "genericWebHook")]
        public Comgithubopenshiftapibuildv1GenericWebHookCause GenericWebHook { get; set; }

        /// <summary>
        /// gitHubWebHook represents data for a GitHub webhook that fired a
        /// specific build.
        /// </summary>
        [JsonProperty(PropertyName = "githubWebHook")]
        public Comgithubopenshiftapibuildv1GitHubWebHookCause GithubWebHook { get; set; }

        /// <summary>
        /// GitLabWebHook represents data for a GitLab webhook that fired a
        /// specific build.
        /// </summary>
        [JsonProperty(PropertyName = "gitlabWebHook")]
        public Comgithubopenshiftapibuildv1GitLabWebHookCause GitlabWebHook { get; set; }

        /// <summary>
        /// imageChangeBuild stores information about an imagechange event
        /// that triggered a new build.
        /// </summary>
        [JsonProperty(PropertyName = "imageChangeBuild")]
        public Comgithubopenshiftapibuildv1ImageChangeCause ImageChangeBuild { get; set; }

        /// <summary>
        /// message is used to store a human readable message for why the
        /// build was triggered. E.g.: "Manually triggered by user",
        /// "Configuration change",etc.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.BitbucketWebHook != null)
            {
                this.BitbucketWebHook.Validate();
            }
            if (this.GenericWebHook != null)
            {
                this.GenericWebHook.Validate();
            }
            if (this.GithubWebHook != null)
            {
                this.GithubWebHook.Validate();
            }
            if (this.GitlabWebHook != null)
            {
                this.GitlabWebHook.Validate();
            }
        }
    }
}