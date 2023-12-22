using ApplicationLayer.Queries;
using ApplicationLayer.Storages.Classes.Repos;
using MediatR;
using PetsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Handlers;

public class GetAnimalTypesQueryHandler : IRequestHandler<GetAnimalTypesQuery, IEnumerable<AnimalType>>
{

    private readonly AnimalTypeRepository _animalTypeRepository;

    public GetAnimalTypesQueryHandler(AnimalTypeRepository animalTypeRepository)
    {
        _animalTypeRepository = animalTypeRepository;
    }

    public async Task<IEnumerable<AnimalType>> Handle(GetAnimalTypesQuery request, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await _animalTypeRepository.GetAllAsync();
    }
}