using Flunt.Notifications;

using Household.Budget.Contracts.Http.Responses;

namespace Household.Budget.UseCases.Identity.CreateAdminUser;

public class CreateAdminUserResponse : AbstractResponse<CreateAdminUserResponseViewModel>
{
    public CreateAdminUserResponse(CreateAdminUserResponseViewModel response) : base(response) { }
    public CreateAdminUserResponse(IEnumerable<Notification> errors) : base(errors) { }
}

public class CreateAdminUserResponseViewModel(string id, CreateAdminUserRequest request)
{
    public string Id { get; set; } = id;
    public string UserName { get; set; } = request.UserName;
    public string Email { get; set; } = request.Email;
}