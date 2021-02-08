using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.UserServices.Validators
{
    public interface IValidator<T> where T : class
    {
        public bool ExecuteValidator(T validateObject);
    }
}
