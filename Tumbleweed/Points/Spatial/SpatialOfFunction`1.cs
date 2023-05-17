using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace Tumbleweed.Points.Spatial;

public sealed class SpatialOfFunction<T> : SpatialEnvelope<T>
{
	public SpatialOfFunction(Func<ISpatial<T>> function) : this
	(
		new FunctionFromSystem<ISpatial<T>>(function)
	)
	{
	}
	
	public SpatialOfFunction(IFunction<ISpatial<T>> function) : base
	(
		new SpatialOfScalar<T>(
			new ResultOfFunction<ISpatial<T>>(function))
	)
	{
	}
}