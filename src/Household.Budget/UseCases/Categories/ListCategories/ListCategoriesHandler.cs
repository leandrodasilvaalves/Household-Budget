﻿using Household.Budget.Contracts.Data;

using MediatR;

namespace Household.Budget.UseCases.Categories.ListCategories;

public class ListCategoriesHandler : IRequestHandler<ListCategoriesRequest, ListCategoriesResponse>
{
    private readonly ICategoryRepository _categoryRepository;

    public ListCategoriesHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
    }

    public async Task<ListCategoriesResponse> Handle(ListCategoriesRequest request, CancellationToken cancellationToken)
    {
        var result = await _categoryRepository.GetAllAsync(request.PageSize, request.PageNumber, request.UserId, cancellationToken);
        return new ListCategoriesResponse(result);
    }
}
