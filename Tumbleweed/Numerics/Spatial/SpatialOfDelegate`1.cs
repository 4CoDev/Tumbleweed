using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Spatial;

public sealed class SpatialOfDelegate<T> : SpatialEnvelope<T>
{
	public SpatialOfDelegate(Func<ISpatial<T>> @delegate) : base
	(
		new SpatialOfScalar<T>(
			new ValueOfFunction<ISpatial<T>>(@delegate))
	)
	{
	}
}