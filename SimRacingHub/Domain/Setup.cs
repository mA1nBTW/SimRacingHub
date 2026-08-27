namespace SimRacingHub.Domain
{
    public class Setup
    {
        public Guid Id { get; set; }

        public Guid UserId {  get; set; }
        public Guid GameId {  get; set; }
        public Guid CarId {  get; set; }
        public Guid TrackId {  get; set; }

        public Guid? ParentSetupId { get; set; }

        public string InputDevice { get; set; } = string.Empty;
        public string? DeviceModel { get; set; }
        public string Title { get; set; } = string.Empty;

        public SetupParametersBase Parameters { get; set; } = null!;

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
