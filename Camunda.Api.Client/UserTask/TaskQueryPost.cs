using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.UserTask
{
    public class TaskQueryPost : TaskQuery
    {
        /// <summary>
        /// A JSON array which contains at least one OR query JSON Object. All previously listed filter criteria can be used inside of this JSON object.
        /// </summary>
        [JsonProperty("orQueries")]
        public List<TaskQuery> OrQueries;
    }
}