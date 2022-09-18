using AutoMapper;
using Elasticsearch.Net;
using Nest;
using Rtl.WebApi.Models.Api;
using Rtl.WebApi.Models.Dto;
using Rtl.WebApi.Models.Shared;

namespace Rtl.WebApi.Services
{
    public class ShowService : IShowService
    {
        private readonly ElasticClient _elasticClient;
        private readonly IMapper _mapper;
        public ShowService(ElasticClient elasticClient, IMapper mapper)
        {
            _elasticClient = elasticClient;
            _mapper = mapper;
        }

        public async Task<Pagination<ShowResponse>> GetShowAsync(Pagination pagination)
        {
            var searchResult = await _elasticClient.SearchAsync<ShowDocument>(s => s
                            .Index("shows")
                            .From(pagination.Offset)
                            .Size(pagination.Limit));

            var mappedSearchResult =  _mapper.Map<List<ShowResponse>>(searchResult.Documents);

            return new Pagination<ShowResponse>
            {
                Results = mappedSearchResult,
                Total = searchResult.Total,
                Limit = pagination.Limit,
                Offset = pagination.Offset
            };
        }

    }
}
