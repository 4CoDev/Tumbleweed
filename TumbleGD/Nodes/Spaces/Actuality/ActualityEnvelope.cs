namespace TumbleGD.Nodes.Spaces.Actuality;

public abstract class ActualityEnvelope : ISpaceActuality
{
	protected ActualityEnvelope(ISpaceActuality actuality) =>
		this.actuality = actuality;
	
	public void Update() => actuality.Update();

	private readonly ISpaceActuality actuality;
}