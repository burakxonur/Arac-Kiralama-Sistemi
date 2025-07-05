using CareBook.Application.Features.Mediator.Queries.AppUserQueries;
using CareBook.Application.Features.Mediator.Results.AppUserResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.AppUserHandler
{
    public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {
        private readonly IRepository<AppUser> _AppUserRepository;
        private readonly IRepository<AppRole> _AppRoleRepository;

        public GetCheckAppUserQueryHandler(IRepository<AppUser> appUserRepository, IRepository<AppRole> appRoleRepository)
        {
            _AppUserRepository = appUserRepository;
            _AppRoleRepository = appRoleRepository;
        }

        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserQueryResult();
            var user = await _AppUserRepository.GetByFılterAsync(x => x.UserName == request.UserName && x.Password == request.Password);

            if (user != null)
            {
                values.IsExist = true; // kullanıcı varsa true
                values.UserName = user.UserName;
                values.Role = (await _AppRoleRepository.GetByFılterAsync(x => x.AppRoleID == user.AppRoleID)).AppRoleName;
                values.ID = user.AppUserID;
            }
            else
            {
                values.IsExist = false; // kullanıcı yoksa false
            }
            return values;

        }
    }
}
