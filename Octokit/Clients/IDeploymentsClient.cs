using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Repository Deployments API.
    /// Gets and creates Deployments.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/repos/deployments/">Repository Deployments API documentation</a> for more information.
    /// </remarks>
    public interface IDeploymentsClient
    {
        /// <summary>
        /// Gets all the deployments for the specified repository. Any user with pull access
        /// to a repository can view deployments.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/repos/deployments/#list-deployments
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <returns>All the <see cref="GitDeployment"/>s for the specified repository.</returns>
        Task<IReadOnlyList<GitDeployment>> GetAll(string owner, string name);
        
        /// <summary>
        /// Creates a new deployment for the specified repository.
        /// Users with push access can create a deployment for a given ref.
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="newDeployment">A <see cref="NewDeployment"/> instance describing the new deployment to create</param>
        /// <returns>The created <see cref="GitDeployment"></returns>
        Task<GitDeployment> Create(string owner, string name, NewDeployment newDeployment);

        /// <summary>
        /// Client for managing deployment status.
        /// </summary>
        IDeploymentStatusClient Status { get; }
    }
}