using Household.Budget.Contracts.Errors;
using Household.Budget.Contracts.Http.Responses;
using Household.Budget.Contracts.Models;

namespace Household.Budget.UseCases.Categories.UpdateCategory;

public class UpdateCategoryResponse : AbstractResponse<Category>
{
    public UpdateCategoryResponse(Category data) : base(data) { }

    protected override Response NotFoundError() =>
        new(CategoryErrors.CATEGORY_NOT_FOUND);
}
