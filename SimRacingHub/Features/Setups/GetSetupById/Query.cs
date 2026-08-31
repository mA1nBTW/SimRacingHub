using MediatR;
using SimRacingHub.Domain;

namespace SimRacingHub.Features.Setups.GetSetupById
{
    public record Query(Guid Id) : IRequest<Setup?>;
}
