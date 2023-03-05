using Tumbleweed.Delegates.Actions;
using Tumbleweed.Delegates.Actions.Nullary;

namespace TumbleGD.Nodes.Pools;

public sealed class PoolWithValues : INodePool
{
	public PoolWithValues
	(
		IDictionary<Object, INullaryAction> graphicals,
		IDictionary<Object, INullaryAction> physicals,
		IDictionary<Object, INullaryAction> inputtings,
		IDictionary<Object, Object> listenings
	)
	{
		Graphicals = graphicals;
		Physicals = physicals;
		Inputs = inputtings;
		Listenings = listenings;
	}
	
	public IDictionary<Object, INullaryAction> Graphicals { get; }

	public IDictionary<Object, INullaryAction> Physicals { get; }

	public IDictionary<Object, INullaryAction> Inputs { get; }
	
	public IDictionary<Object, Object> Listenings { get; }
}