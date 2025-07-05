using CareBook.Application.Features.Mediator.Commands.BlogCommands;
using CareBook.Application.Features.Mediator.Commands.LocationCommands;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.BlogID);
            values.Title = request.Title;
            values.Description = request.Description;
            values.CoverImageUrl = request.CoverImageUrl;
            values.CreatedDate = request.CreatedDate;
            values.AuthorID = request.AuthorID;
            values.CategoryID = request.CategoryID;
            await _repository.UpdatedAsync(values);
        }
    }
}
