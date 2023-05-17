using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace Tumbleweed.Points.Planar;

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