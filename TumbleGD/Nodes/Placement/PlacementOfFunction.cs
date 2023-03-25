using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement;

public sealed class PlacementOfFunction : PlacementEnvelope
{
	public PlacementOfFunction
	(
		Func<INodePlacement> function
	) : this
	(
		new NullaryFromSystem<INodePlacement>(function)
	)
	{
	}

	public PlacementOfFunction
	(
		INullaryFunction<INodePlacement> function
	) : base
	(
		new PlacementOfScalar(
			new ValueOfFunction<INodePlacement>(function))
	)
	{
	}
}