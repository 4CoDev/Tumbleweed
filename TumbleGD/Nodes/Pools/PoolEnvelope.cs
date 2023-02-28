using Tumbleweed.Delegates.Actions;
using Tumbleweed.Delegates.Actions.Nullary;

namespace TumbleGD.Nodes.Pools;

public abstract class PoolEnvelope : INodePool
{
	protected PoolEnvelope(INodePool pool)
	{
		this.pool = pool;
	}
	
	public IDictionary<object, INullaryAction> Graphicals =>
		pool.Graphicals;

	public IDictionary<object, INullaryAction> Physicals =>
		pool.Physicals;

	public IDictionary<object, INullaryAction> Inputs =>
		pool.Inputs;

	public IDictionary<object, object> Listenings =>
		pool.Listenings;

	private readonly INodePool pool;
}