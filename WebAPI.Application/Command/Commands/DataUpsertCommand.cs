using WebAPI.Application.Shared.CQRS;

namespace WebAPI.Application.Command.Commands
{
    public class DataUpsertCommand : ICommand
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
