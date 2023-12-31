using Flunt.Validations;
using Household.Budget.Contracts.Extensions;

namespace Household.Budget;

public class ChangeUserPasswordRequestContract : Contract<ChangeUserPasswordRequest>
{
    public ChangeUserPasswordRequestContract(ChangeUserPasswordRequest request)
    {
        Requires()
            .IsNotNullOrEmpty(request.CurrentPassword, IdentityErrors.CURRENT_PASSWORD_IS_REQUIRED)
            .IsNotNullOrEmpty(request.NewPassword, IdentityErrors.NEW_PASSWORD_IS_REQUIRED)
            .IsNotNullOrEmpty(request.ConfirmNewPassword, IdentityErrors.CONFIRM_NEW_PASSWORD_IS_REQUIRED)
            .AreEquals(request.NewPassword, request.ConfirmNewPassword, IdentityErrors.NEW_PASSOWRD_MUST_BE_EQUAL_TO_CONFIRM_NEW_PASSWORD);
    }
}

