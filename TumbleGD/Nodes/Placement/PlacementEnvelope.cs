namespace TumbleGD.Nodes.Placement;

public abstract class PlacementEnvelope : INodePlacement
{
	protected PlacementEnvelope(INodePlacement placement) =>
		this.placement = placement;
	
	public void Place() => placement.Place();

	public void Remove() => placement.Remove();

	public override bool Equals(object? @object) =>
		placement.Equals(@object);

	public override int GetHashCode() =>
		placement.GetHashCode();

	public override string? ToString() =>
		placement.ToString();

	private readonly INodePlacement placement;
}