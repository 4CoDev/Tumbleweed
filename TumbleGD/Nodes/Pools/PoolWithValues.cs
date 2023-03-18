using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Nodes.Pools;

public sealed class PoolWithValues : INodePool
{
	public PoolWithValues
	(
		INullaryEvent graphicals,
		INullaryEvent physicals,
		INullaryEvent inputs
	)
	{
		Graphicals = graphicals;
		Physicals = physicals;
		Inputs = inputs;
	}
	
	public INullaryEvent Graphicals { get; }

	public INullaryEvent Physicals { get; }

	public INullaryEvent Inputs { get; }
}