﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Domain.Models
{
    public record UnvalidatedUserCredentials(string CNP, string FirstName, string LastName, string NoCard, string ExpDateCard, string cvc2);
}
