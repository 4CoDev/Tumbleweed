using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Spatial;

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