using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement;

public sealed class PlacementOfScalar : INodePlacement
{
	public PlacementOfScalar(IScalar<INodePlacement> scalar) =>
		this.scalar = scalar;

	public void Place(IScalar<Node> parent) =>
		scalar.Value.Place(parent);

	public void Remove() => scalar.Value.Remove();
	
	private readonly IScalar<INodePlacement> scalar;
}