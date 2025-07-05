using CareBook.Application.Features.CQRS.Comments.ContactCommands;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.ContactHandlers
{
  public  class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIDAsync(command.ContactID);
            values.Name = command.Name;
            values.Email = command.Email;
            values.Subject = command.Subject;
            values.Message = command.Message;
            values.SendDate = command.SendDate;
            await _repository.UpdatedAsync(values);
        }
    }
}
