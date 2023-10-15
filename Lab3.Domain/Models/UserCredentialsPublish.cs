using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Domain.Models
{
    public static partial class UserCredentialsPublish
    {
        public interface IUserCredentialsPublish { }

        public record UserCredentialsPublishScucceededEvent : IUserCredentialsPublish
        {
            public string Csv { get; }
            public DateTime PublishedDate { get; }

            internal UserCredentialsPublishScucceededEvent(string csv, DateTime publishedDate)
            {
                Csv = csv;
                PublishedDate = publishedDate;
            }
        }
    }
}
