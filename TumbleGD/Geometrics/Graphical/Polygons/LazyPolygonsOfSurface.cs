using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.Lazy;

namespace TumbleGD.Geometrics.Graphical.Polygons;

public sealed class LazyPolygonsOfSurface : EnumerableEnvelope<IPolygon>
{
	public LazyPolygonsOfSurface(ISurface surface) : base
	(
		new Tumbleweed.Enumerables.Lazy.SelectedByExpression<IPolygon>(
			new PolygonsOfSurface(surface),
			polygon => new LazyPolygon(polygon))
	)
	{
	}
}