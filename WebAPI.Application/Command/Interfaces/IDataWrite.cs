using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Command.Commands;
using WebAPI.Application.Shared.CQRS;

namespace WebAPI.Application.Command.Interfaces
{
    public interface IDataWrite:ICommandHandler<DataUpsertCommand>;
}
