using DotGod.Geometry.Spatial.Graphical.Surfaces;
using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Spatial.Graphical.Polygons;

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