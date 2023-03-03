using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nodes.NAry;

public sealed class NAryNodeOfDelegate<T> : NAryNodeEnvelope<T>
{
	public NAryNodeOfDelegate(Func<INAryNode<T>> function) : this
	(
		new NullaryFromSystem<INAryNode<T>>(function)
	)
	{
	}
	
	public NAryNodeOfDelegate
	(
		INullaryFunction<INAryNode<T>> function
	) : base
	(
		new NAryNodeOfScalar<T>(
			new ValueOfDelegate<INAryNode<T>>(
				function))
	)
	{
	}
}