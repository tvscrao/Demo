using Newtonsoft.Json;
using System.Text.Json;

namespace Demo
{
    internal class QueryService : IQueryService
    {
        #region Properties
        private IHttpClientFactory _httpClientFactory { get; }
        private readonly string? _publicURL;
        private readonly ILogger _logger;
        #endregion

        #region Constructor
        public QueryService(IHttpClientFactory httpClientFactory, IConfiguration configuration, ILogger logger)
        { 
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _publicURL = configuration.GetSection("API").Value;
        }
        #endregion

        #region GetPeople from REST Url
        public async Task<People[]> GetPeopleAsync()
        { 
            using (var client = _httpClientFactory.CreateClient("rest"))
            {
                var content = await client.GetByteArrayAsync($"{_publicURL}/people");
                return JsonConvert.DeserializeObject<People[]>
                    (JsonDocument.Parse(content).RootElement.GetProperty("results").ToString());
            }
        }
        #endregion

        #region GetPeopleById from REST Url
        public async Task<People> GetPeopleByIdAsync(int id)
        { 
            using (var client = _httpClientFactory.CreateClient("rest"))
            {
                var content = await client.GetByteArrayAsync($"{_publicURL}/people/{id}");
                return JsonConvert.DeserializeObject<People>
                        (JsonDocument.Parse(content).RootElement.ToString());
             } 
        }
        #endregion
    }
}
