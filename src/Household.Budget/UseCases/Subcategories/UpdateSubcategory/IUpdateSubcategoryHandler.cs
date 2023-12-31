namespace Household.Budget.UseCases.Categories.UpdateSubcategory;

public interface IUpdateSubcategoryHandler
{
    Task<UpdateSubcategoryResponse> HandleAsync(UpdateSubcategoryRequest request, CancellationToken cancellationToken);
}
