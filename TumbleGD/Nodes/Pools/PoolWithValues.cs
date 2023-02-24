using Tumbleweed.Delegates.Actions;

namespace TumbleGD.Nodes.Pools;

public sealed class PoolWithValues : INodePool
{
	public PoolWithValues
	(
		IDictionary<object, IAction> graphicals,
		IDictionary<object, IAction> physicals,
		IDictionary<object, IAction> inputtings,
		IDictionary<object, object> listenings
	)
	{
		Graphicals = graphicals;
		Physicals = physicals;
		Inputs = inputtings;
		Listenings = listenings;
	}
	
	public IDictionary<object, IAction> Graphicals { get; }

	public IDictionary<object, IAction> Physicals { get; }

	public IDictionary<object, IAction> Inputs { get; }
	
	public IDictionary<object, object> Listenings { get; }
}