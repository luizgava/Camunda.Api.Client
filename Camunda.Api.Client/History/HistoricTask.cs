using System;

namespace Camunda.Api.Client.History
{
    public class HistoricTask
    {
        public string Id;
        public string ProcessDefinitionKey;
        public string ProcessDefinitionId;
        public string ProcessInstanceId;
        public string ExecutionId;
        public string CaseDefinitionKey;
        public string CaseDefinitionId;
        public string CaseInstanceId;
        public string CaseExecutionId;
        public string ActivityInstanceId;
        public string Name;
        public string Description;
        public string DeleteReason;
        public string Owner;
        public string Assignee;
        public DateTime? StartTime;
        public DateTime? EndTime;
        public long Duration;
        public string TaskDefinitionKey;
        public long Priority;
        public DateTime? Due;
        public string ParentTaskId;
        public DateTime? FollowUp;
        public string TenantId;
        public DateTime? RemovalTime;
        public string RootProcessInstanceId;

        public override string ToString() => Id;
    }
}
