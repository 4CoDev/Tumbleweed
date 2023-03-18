using Tumbleweed.Delegates.Actions;
using Tumbleweed.Delegates.Actions.Nullary;

namespace TumbleGD.Nodes.Pools;

public class EmptyPool : PoolEnvelope
{
	public EmptyPool() : base
	(
		new PoolWithValues(
			new Dictionary<Object, INullaryAction>(),
			new Dictionary<Object, INullaryAction>(),
			new Dictionary<Object, INullaryAction>())
	)
	{
	}
}