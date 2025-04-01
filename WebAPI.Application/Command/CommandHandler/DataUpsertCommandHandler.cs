using WebAPI.Application.Command.Commands;
using WebAPI.Application.Command.Interfaces;
using WebAPI.Application.Interfaces.Repository;
using WebAPI.Application.Shared.ExceptionHandling;
using WebAPI.Domain.DTOs;

namespace WebAPI.Application.Command.CommandHandler
{
    public class DataUpsertCommandHandler : IDataWrite
    {
        private readonly IDataUpsertRepository _upsertRepository;
        public DataUpsertCommandHandler(IDataUpsertRepository upsertRepository) {
            _upsertRepository = upsertRepository;
        }
        public async Task<Result> Handle(DataUpsertCommand command, CancellationToken cancellationToken)
        {
            var response = await _upsertRepository.DataUpsert(new DataUpsertDTO()
            {
                Id = command.Id,
                UserName = command.UserName,
                Password = command.Password,
                Role = command.Role
            });

            return Result.Success(response);
        }
    }
}
