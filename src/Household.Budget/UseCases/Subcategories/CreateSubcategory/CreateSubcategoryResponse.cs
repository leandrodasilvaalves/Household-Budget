using Flunt.Notifications;

using Household.Budget.Contracts.Http.Responses;
using Household.Budget.Contracts.Models;

namespace Household.Budget.UseCases.Subcategories.CreateSubcategory;

public class CreateSubcategoryResponse : AbstractResponse<Subcategory>
{
    public CreateSubcategoryResponse(Subcategory data) : base(data) { }

    public CreateSubcategoryResponse(Notification notification) : base(notification) { }
}