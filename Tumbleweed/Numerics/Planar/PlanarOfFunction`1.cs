using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Planar;

public sealed class PlanarOfFunction<T> : PlanarEnvelope<T>
{
	public PlanarOfFunction(Func<IPlanar<T>> function) : this
	(
		new FunctionFromSystem<IPlanar<T>>(function)
	)
	{
	}
	
	public PlanarOfFunction(INullaryFunction<IPlanar<T>> function) : base
	(
		new PlanarOfScalar<T>(
			new ValueOfFunction<IPlanar<T>>(function))
	)
	{
	}
}