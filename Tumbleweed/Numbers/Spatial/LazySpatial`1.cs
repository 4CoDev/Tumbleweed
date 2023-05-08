using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Spatial;

public sealed class LazySpatial<T> : SpatialEnvelope<T>
{
	public LazySpatial(ISpatial<T> spatial) : base
	(
		new SpatialWithCoordinates<T>(
			new LazyResultOfFunction<T>(() => spatial.X),
			new LazyResultOfFunction<T>(() => spatial.Y),
			new LazyResultOfFunction<T>(() => spatial.Z))
	)
	{
	}
}