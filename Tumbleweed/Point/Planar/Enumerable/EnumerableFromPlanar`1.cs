using Tumbleweed._Enumerable;

namespace Tumbleweed.Point.Planar.Enumerable;

public sealed class EnumerableFromPlanar<T> : EnumerableEnvelope<T>
{
	public EnumerableFromPlanar(IPoint<T> spatial) : base
	(
		new EnumerableWithElements<T>(
			spatial.X,
			spatial.Y)
	)
	{
	}
}