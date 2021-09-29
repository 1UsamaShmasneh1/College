using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    public class NotValidInbutExcebtion : ApplicationException
    {
        public NotValidInbutExcebtion()
        {
        }

        public NotValidInbutExcebtion(string? message) : base(message)
        {
        }

        public NotValidInbutExcebtion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotValidInbutExcebtion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
