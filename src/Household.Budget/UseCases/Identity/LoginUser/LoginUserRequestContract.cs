using Flunt.Validations;
using Household.Budget.Contracts.Extensions;

namespace Household.Budget;

public class LoginUserRequestContract : Contract<LoginUserRequest>
{
    public LoginUserRequestContract(LoginUserRequest request)
    {   
        Requires()
            .IsNotNullOrEmpty(request.UserName, IdentityErrors.USER_NAME_IS_REQUIRED)
            .IsNotNullOrEmpty(request.Password, IdentityErrors.PASSWORD_IS_REQUIRED);
    }
}