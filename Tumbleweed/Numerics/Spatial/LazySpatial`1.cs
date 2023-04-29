using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Spatial;

public sealed class LazySpatial<T> : SpatialEnvelope<T>
{
	public LazySpatial(ISpatial<T> spatial) : base
	(
		new SpatialWithCoordinates<T>(
			new LazyFunction<T>(() => spatial.X),
			new LazyFunction<T>(() => spatial.Y),
			new LazyFunction<T>(() => spatial.Z))
	)
	{
	}
}