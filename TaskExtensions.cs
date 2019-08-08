using System.Threading.Tasks;

namespace Penguin.Extensions.Async
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static class TaskExtensions
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        #region Methods

        /// <summary>
        /// Waits for the task to complete and then returns the result
        /// </summary>
        /// <typeparam name="T">The result type</typeparam>
        /// <param name="task">the task to await</param>
        /// <returns>The result</returns>
        public static T GetResult<T>(this Task<T> task)
        {
            task.Wait();

            return task.Result;
        }

        #endregion Methods
    }
}