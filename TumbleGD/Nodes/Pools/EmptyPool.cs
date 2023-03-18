using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Nodes.Pools;

public class EmptyPool : PoolEnvelope
{
	public EmptyPool() : base
	(
		new PoolWithValues(
			new EmptyEvent(),
			new EmptyEvent(),
			new EmptyEvent())
	)
	{
	}
}