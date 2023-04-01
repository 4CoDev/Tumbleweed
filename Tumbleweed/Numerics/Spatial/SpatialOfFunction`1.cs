using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Spatial;

public sealed class SpatialOfFunction<T> : SpatialEnvelope<T>
{
	public SpatialOfFunction(Func<ISpatial<T>> function) : this
	(
		new NullaryFromSystem<ISpatial<T>>(function)
	)
	{
	}
	
	public SpatialOfFunction(INullaryFunction<ISpatial<T>> function) : base
	(
		new SpatialOfScalar<T>(
			new ValueOfFunction<ISpatial<T>>(function))
	)
	{
	}
}