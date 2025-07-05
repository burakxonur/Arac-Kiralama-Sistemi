using CareBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using CareBook.Application.Features.Mediator.Results.ServiceResults;
using CareBook.Application.Features.Mediator.Results.SocialMediaResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.SocialMediaHandler
{
    public class GetSocialMediaByIDQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQuertResult>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIDQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQuertResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.ID);
            return new GetSocialMediaByIdQuertResult
            {
                SocialMediaID = values.SocialMediaID,
                Name = values.Name,
                Url = values.Url,
                Icon = values.Icon,
            };
        }
    }
}
