using CareBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CareBook.Application.Features.Mediator.Results.StatisticsResult;
using CareBook.Application.İnterfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.StatisticsHandler
{
    public class BlogTitleByMaxBlogCommentQueryHandler : IRequestHandler<BlogTitleByMaxBlogCommentQuery, BlogTitleByMaxBlogCommentQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public BlogTitleByMaxBlogCommentQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<BlogTitleByMaxBlogCommentQueryResult> Handle(BlogTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.BlogTitleByMaxBlogComment();
            return new BlogTitleByMaxBlogCommentQueryResult
            {
                BlogTitleByMaxBlogComment = value,
            };
        }
    
    }
}
