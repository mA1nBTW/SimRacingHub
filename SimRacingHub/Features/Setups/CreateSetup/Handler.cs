using SimRacingHub.Domain;
using MediatR;
using SimRacingHub.Infrastructure;

namespace SimRacingHub.Features.Setups.CreateSetup;
public class Handler : IRequestHandler<Command, Guid>
{
    private readonly AppDbContext _DbContext;

    public Handler(AppDbContext dbContext)
    {
        _DbContext = dbContext;
    }

    public async Task<Guid> Handle(Command request, CancellationToken cancellationToken)
    {
        var fakeUserId = Guid.NewGuid();

        var setup = new Setup
        {
            Id = Guid.NewGuid(),
            UserId = fakeUserId,
            GameId = request.GameId,
            CarId = request.CarId,
            TrackId = request.TrackId,
            ParentSetupId = null,
            InputDevice = request.InputDevice,
            DeviceModel = request.DeviceModel,
            Title = request.Title,
            Parameters = request.Parameters,
            CreatedAt = DateTime.UtcNow
        };

        _DbContext.Setups.Add(setup);
        await _DbContext.SaveChangesAsync();

        return setup.Id;
    }
}
