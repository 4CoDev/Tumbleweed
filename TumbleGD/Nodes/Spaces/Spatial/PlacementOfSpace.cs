using Godot;
using TumbleGD.Nodes.Placement;
using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial;

public sealed class PlacementOfSpace : PlacementEnvelope
{
	public PlacementOfSpace
	(
		Node space
	) : this
	(
		new ScalarOfValue<Node>(space)
	)
	{
	}
	
	public PlacementOfSpace
	(
		IScalar<Node> space
	) : base
	(
		 new PlacementOfNode(space)
	)
	{
	}
}