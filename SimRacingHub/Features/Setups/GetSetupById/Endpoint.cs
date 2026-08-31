using MediatR;

namespace SimRacingHub.Features.Setups.GetSetupById;
public static class Endpoint
{
    public static void MapGetSetupByIdEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/setups/{id:guid}", async (Guid id, IMediator mediator) =>
        {
            var setup = await mediator.Send(new Query(id));
            if (setup is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(setup);
        })
        .WithName("GetSetupById");
    }
}
