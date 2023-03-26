using TumbleGD.Nodes.FromFiles.OfGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement.FromFiles;

public sealed class PlacementOfNode : PlacementEnvelope
{
	public PlacementOfNode(String path) : this
	(
		new ScalarOfValue<String>(path)
	)
	{
	}

	public PlacementOfNode
	(
		IScalar<String> path
	) : base
	(
		new Placement.PlacementOfNode(
			new NodeOnPath(path))
	)
	{
	}
}