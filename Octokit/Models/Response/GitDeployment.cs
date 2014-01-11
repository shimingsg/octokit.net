using System;

namespace Octokit
{
    public class GitDeployment
    {
        /// <summary>
        /// Id of this deployment.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sha { get; set; }

        /// <summary>
        /// The API URL for this deployment.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The <seealso cref="User"/> that created the deployment.
        /// </summary>
        public User Creator { get; set; }

        /// <summary>
        /// JSON payload with extra information about the deployment.
        /// </summary>
        public string Payload { get; set; }

        /// <summary>
        /// Date and time that the deployment was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date and time that the deployment was updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// A short description of the deployment.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The API URL for the <seealso cref="DeploymentStatus"/>es of this deployment.
        /// </summary>
        public string StatusesUrl { get; set; }
    }
}