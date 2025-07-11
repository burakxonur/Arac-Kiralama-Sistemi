﻿using CareBook.Application.Features.Mediator.Queries.BlogQueries;
using CareBook.Application.Features.Mediator.Results.BlogResults;
using CareBook.Application.İnterfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIDQueryHandler : IRequestHandler<GetBlogByAuthorIDQuery, List<GetBlogByAuthorIDQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByAuthorIDQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogByAuthorIDQueryResult>> Handle(GetBlogByAuthorIDQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBlogByAuthorID(request.ID);
            return values.Select(x => new GetBlogByAuthorIDQueryResult
            {
                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                AuthorName = x.Author.Name,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl,
            }).ToList();
        }
    }
}
