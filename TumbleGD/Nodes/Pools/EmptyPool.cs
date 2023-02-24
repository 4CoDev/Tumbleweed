using Tumbleweed.Delegates.Actions;

namespace TumbleGD.Nodes.Pools;

public class EmptyPool : PoolEnvelope
{
	public EmptyPool() : base
	(
		new PoolWithValues(
			new Dictionary<object, IAction>(),
			new Dictionary<object, IAction>(),
			new Dictionary<object, IAction>(),
			new Dictionary<object, object>())
	)
	{
	}
}