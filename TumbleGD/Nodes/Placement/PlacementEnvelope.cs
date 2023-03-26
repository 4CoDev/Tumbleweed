using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement;

public abstract class PlacementEnvelope : INodePlacement
{
	protected PlacementEnvelope(INodePlacement placement) =>
		this.placement = placement;

	public void Place(Node parent) =>
		placement.Place(parent);

	public void Remove() => placement.Remove();

	private readonly INodePlacement placement;
}