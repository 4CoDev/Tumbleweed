using Tumbleweed.Delegates.Actions;

namespace TumbleGD.Nodes.Pools;

public abstract class PoolEnvelope : INodePool
{
	protected PoolEnvelope(INodePool pool)
	{
		this.pool = pool;
	}
	
	public IDictionary<object, IAction> Graphicals =>
		pool.Graphicals;

	public IDictionary<object, IAction> Physicals =>
		pool.Physicals;

	public IDictionary<object, IAction> Inputs =>
		pool.Inputs;

	public IDictionary<object, object> Listenings =>
		pool.Listenings;

	private readonly INodePool pool;
}