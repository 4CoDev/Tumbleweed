using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;

namespace TumbleGD.Geometrics.Graphical.Polygons;

public sealed class LazyPolygonsOfSurface : EnumerableEnvelope<IPolygon>
{
	public LazyPolygonsOfSurface(ISurface surface) : base
	(
		new LazySelectedByExpression<IPolygon>(
			new PolygonsOfSurface(surface),
			polygon => new LazyPolygon(polygon))
	)
	{
	}
}