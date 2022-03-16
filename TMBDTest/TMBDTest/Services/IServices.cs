using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMBDTest.Models;

namespace TMBDTest.Services
{
    public interface IServices
    {
        Task<GenericResponse<TResponse>> Get<TResponse>(string url, bool body);
    }
}
