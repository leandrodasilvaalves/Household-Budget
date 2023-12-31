using Household.Budget.Contracts.Http.StatusCodeResults;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Household.Budget.Contracts.Http.Controllers
{
    [Authorize]
    public abstract class CustomControllerBase : ControllerBase
    {
        [NonAction]
        public CustomNoContentResult NoContent([ActionResultObjectValue] object? value)
        {
            return new CustomNoContentResult(value);
        }
    }
}