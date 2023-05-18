using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace Tumbleweed.Points.Planar;

public sealed class PointOfFunction<T> : PointEnvelope<T>
{
	public PointOfFunction(Func<IPoint<T>> function) : this
	(
		new FunctionFromSystem<IPoint<T>>(function)
	)
	{
	}
	
	public PointOfFunction(IFunction<IPoint<T>> function) : base
	(
		new PointOfScalar<T>(
			new ResultOfFunction<IPoint<T>>(function))
	)
	{
	}
}