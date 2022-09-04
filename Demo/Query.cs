namespace Demo
{
    public class Query : IQueryBase
    {
        #region Properties
        private IQueryService _queryService { get; }
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        #endregion

        #region Constructor
        public Query(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            var logger = LoggerFactory.Create(config =>
            {
                config.AddConsole();
            }).CreateLogger("Demo");

            _queryService = new QueryService(httpClientFactory, configuration, logger);
            _configuration = configuration;
            _logger = logger;
        }
        
        public Query(IHttpClientFactory httpClientFactory, IQueryService queryService)
        {
            _queryService = queryService;
        }
        #endregion

        #region GetPeople Query
        [GraphQLType("[People]")]
        public async Task<People[]?> GetPeople()
        {
            try
            {     
                return await _queryService.GetPeopleAsync();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error in GetPeople"); 
                return null;
            }
        }
        #endregion

        #region GetPeopleById Query
        [GraphQLType("People")]
        public async Task<People?> GetPeopleById(int id)
        {
            try
            {
                return await _queryService.GetPeopleByIdAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetPeopleById");
                return null;
            }
        }
        #endregion
    }
}
