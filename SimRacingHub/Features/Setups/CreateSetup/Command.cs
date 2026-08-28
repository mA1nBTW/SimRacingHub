using SimRacingHub.Domain;
using MediatR;

namespace SimRacingHub.Features.Setups.CreateSetup;

public record Command(
    Guid GameId,
    Guid CarId,
    Guid TrackId,
    string InputDevice,
    string? DeviceModel,
    string Title,
    SetupParametersBase Parameters
) : IRequest<Guid>;
