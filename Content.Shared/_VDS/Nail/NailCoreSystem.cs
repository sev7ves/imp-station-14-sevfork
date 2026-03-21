namespace Content.Shared._VDS.Nail;

public sealed class NailCoreSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        //SubscribeLocalEvent<NailCoreComponent,ComponentStartup>();
    }

    public override void Update(float frameTime)
    {
        base.Update(frameTime);
    }
}
