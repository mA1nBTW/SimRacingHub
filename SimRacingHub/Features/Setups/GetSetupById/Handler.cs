using MediatR;
using Microsoft.EntityFrameworkCore;
using SimRacingHub.Domain;
using SimRacingHub.Infrastructure;

namespace SimRacingHub.Features.Setups.GetSetupById;

public class Handler : IRequestHandler<Query, Setup?>
{
    private readonly AppDbContext _DbContext;

    public Handler(AppDbContext dbContext)
    {
        _DbContext = dbContext;
    }

    public async Task<Setup?> Handle(Query request, CancellationToken cancellationToken)
    {
        return await _DbContext.Setups
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken);
    }
}
