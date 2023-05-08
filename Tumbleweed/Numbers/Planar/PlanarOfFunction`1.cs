using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Planar;

public sealed class PlanarOfFunction<T> : PlanarEnvelope<T>
{
	public PlanarOfFunction(Func<IPlanar<T>> function) : this
	(
		new FunctionFromSystem<IPlanar<T>>(function)
	)
	{
	}
	
	public PlanarOfFunction(IFunction<IPlanar<T>> function) : base
	(
		new PlanarOfScalar<T>(
			new ResultOfFunction<IPlanar<T>>(function))
	)
	{
	}
}