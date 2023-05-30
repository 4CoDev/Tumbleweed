using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;

namespace Tumbleweed.Planar.Point;

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