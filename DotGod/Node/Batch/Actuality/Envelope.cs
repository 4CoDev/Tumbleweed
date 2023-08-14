using Actuality = DotGod.Node.Batch.Actuality;

namespace DotGod.Node.Batch.Actuality;

public abstract class Envelope : Any
{
	protected Envelope(Actuality::Any actuality) =>
		this.actuality = actuality;
	
	public void Update() =>
		actuality.Update();

	private readonly Actuality::Any actuality;
}