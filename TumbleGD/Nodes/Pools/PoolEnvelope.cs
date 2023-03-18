using Tumbleweed.Delegates.Actions;
using Tumbleweed.Delegates.Actions.Nullary;

namespace TumbleGD.Nodes.Pools;

public abstract class PoolEnvelope : INodePool
{
	protected PoolEnvelope(INodePool pool) =>
		this.pool = pool;

	public IDictionary<Object, INullaryAction> Graphicals =>
		pool.Graphicals;

	public IDictionary<Object, INullaryAction> Physicals =>
		pool.Physicals;

	public IDictionary<Object, INullaryAction> Inputs =>
		pool.Inputs;

	private readonly INodePool pool;
}