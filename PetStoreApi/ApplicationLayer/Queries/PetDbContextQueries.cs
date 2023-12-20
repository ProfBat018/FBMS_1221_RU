using MediatR;
using PetsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Queries;

public record GetPetsQuery : IRequest<IEnumerable<Pet>>;
public record GetProductsQuery : IRequest<IEnumerable<Product>>;
public record GetAnimalTypesQuery : IRequest<IEnumerable<AnimalType>>;
public record GetPetCategoriesQuery : IRequest<IEnumerable<PetCategory>>;
public record GetProductCategoriesQuery : IRequest<IEnumerable<ProductCategory>>;
public record GetProductCategoryTypesQuery : IRequest<IEnumerable<ProductCategoryType>>;



