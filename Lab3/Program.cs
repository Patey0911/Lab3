using System;
using System.Collections.Generic;
using Lab3.Domain.Commands;
using Lab3.Domain.Models;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Input
            var ListOfUsers = ReadListOfUsers().ToArray();
            PublishUserCommand command = new(ListOfUsers);
        }

        private static List<UnvalidatedUserCredentials> ReadListOfUsers()
        {
            List<UnvalidatedUserCredentials> ListOfUsers = new();
            do 
            {
                var CNP = ReadValue("CNP: ");
                if(string.IsNullOrEmpty(CNP)) 
                {
                    break;
                }

                var FirstName = ReadValue("First Name: ");
                if(string.IsNullOrEmpty(FirstName)) 
                {
                    break;
                }

                var LastName = ReadValue("Last Name: ");
                if (string.IsNullOrEmpty(LastName))
                {
                    break;
                }

                var NoCard = ReadValue("NoCard: ");
                if (string.IsNullOrEmpty(NoCard))
                {
                    break;
                }

                var ExpDateCard = ReadValue("Expire Date Card: ");
                if (string.IsNullOrEmpty(ExpDateCard))
                {
                    break;
                }

                var cvc2 = ReadValue("cvc2: ");
                if (string.IsNullOrEmpty(cvc2))
                {
                    break;
                }

                ListOfUsers.Add(new(CNP, FirstName, LastName, NoCard, ExpDateCard, cvc2));
            }while(true);

            return ListOfUsers;
        }
        private static string? ReadValue(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}