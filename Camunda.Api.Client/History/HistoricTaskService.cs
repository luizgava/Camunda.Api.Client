namespace Camunda.Api.Client.History
{
    public class HistoricTaskService
    {
        private IHistoricTaskRestService _api;

        internal HistoricTaskService(IHistoricTaskRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricTaskQuery, HistoricTask> Query(HistoricTaskQuery query = null) =>
            new QueryResource<HistoricTaskQuery, HistoricTask>(_api, query);
    }
}
