using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Nodes.Pools;

public abstract class PoolEnvelope : INodePool
{
	protected PoolEnvelope(INodePool pool) =>
		this.pool = pool;

	public INullaryEvent Graphicals =>
		pool.Graphicals;

	public INullaryEvent Physicals =>
		pool.Physicals;

	public INullaryEvent Inputs =>
		pool.Inputs;

	private readonly INodePool pool;
}