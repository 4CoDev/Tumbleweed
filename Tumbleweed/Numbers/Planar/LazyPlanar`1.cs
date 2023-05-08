using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Planar;

public sealed class LazyPlanar<T> : PlanarEnvelope<T>
{
	public LazyPlanar(IPlanar<T> planar) : base
	(
		new PlanarWithValues<T>(
			new LazyResultOfFunction<T>(() => planar.X),
			new LazyResultOfFunction<T>(() => planar.Y))
	)
	{
	}
}