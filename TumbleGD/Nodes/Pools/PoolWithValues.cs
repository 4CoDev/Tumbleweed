using Tumbleweed.Delegates.Actions;
using Tumbleweed.Delegates.Actions.Nullary;

namespace TumbleGD.Nodes.Pools;

public sealed class PoolWithValues : INodePool
{
	public PoolWithValues
	(
		IDictionary<object, INullaryAction> graphicals,
		IDictionary<object, INullaryAction> physicals,
		IDictionary<object, INullaryAction> inputtings,
		IDictionary<object, object> listenings
	)
	{
		Graphicals = graphicals;
		Physicals = physicals;
		Inputs = inputtings;
		Listenings = listenings;
	}
	
	public IDictionary<object, INullaryAction> Graphicals { get; }

	public IDictionary<object, INullaryAction> Physicals { get; }

	public IDictionary<object, INullaryAction> Inputs { get; }
	
	public IDictionary<object, object> Listenings { get; }
}