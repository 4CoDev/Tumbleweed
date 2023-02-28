using Tumbleweed.Delegates.Actions;
using Tumbleweed.Delegates.Actions.Nullary;

namespace TumbleGD.Nodes.Pools;

public class EmptyPool : PoolEnvelope
{
	public EmptyPool() : base
	(
		new PoolWithValues(
			new Dictionary<object, INullaryAction>(),
			new Dictionary<object, INullaryAction>(),
			new Dictionary<object, INullaryAction>(),
			new Dictionary<object, object>())
	)
	{
	}
}