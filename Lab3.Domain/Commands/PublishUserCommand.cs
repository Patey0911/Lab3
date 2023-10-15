using Lab3.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Domain.Commands
{
    public record PublishUserCommand
    {
        public PublishUserCommand(IReadOnlyCollection<UnvalidatedUserCredentials> inputUserCredentials)
        {
            InputUserCredentials = inputUserCredentials;
        }

        public IReadOnlyCollection<UnvalidatedUserCredentials> InputUserCredentials { get; }
    }
}
