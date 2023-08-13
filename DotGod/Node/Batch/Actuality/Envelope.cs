namespace DotGod.Node.Batch.Actuality;

public abstract class Envelope : Any
{
	protected Envelope(Any actuality) =>
		this.actuality = actuality;
	
	public void Update() =>
		actuality.Update();

	private readonly Any actuality;
}