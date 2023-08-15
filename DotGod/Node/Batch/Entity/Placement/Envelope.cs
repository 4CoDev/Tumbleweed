using Placement = DotGod.Node.Batch.Entity.Placement;

namespace DotGod.Node.Batch.Entity.Placement;

public abstract class Envelope : Placement::Any
{
	protected Envelope(Placement::Any placement) =>
		this.placement = placement;
	
	public void Place() =>
		placement.Place();

	public void Remove() =>
		placement.Remove();
	
	private readonly Placement::Any placement;
}