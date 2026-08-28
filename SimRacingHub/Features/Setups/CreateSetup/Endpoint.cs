using MediatR;

namespace SimRacingHub.Features.Setups.CreateSetup;
public static class Endpoint
{
    public static void MapCreateSetupEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/setups", async (Command command, IMediator mediator) =>
        {
            var setupId = await mediator.Send(command);

            return Results.Created($"/api/setups/{setupId}", new { Id = setupId });
        })
        .WithName("CreateSetup");
    }
}
