namespace Content.Shared._VDS.Nail;
[RegisterComponent]
public sealed partial class NailCoreComponent : Component
{
    public TimeSpan pulseDuration = TimeSpan.FromSeconds(3);

    public TimeSpan pulseInterval = TimeSpan.FromSeconds(10);

    private TimeSpan pulseTimer = TimeSpan.Zero;
}
