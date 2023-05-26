using DotGod.Geometry.Spatial.Graphical.Surface;
using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Polygon;

public sealed class LazyPolygonsOfSurface : EnumerableEnvelope<IPolygon>
{
	public LazyPolygonsOfSurface(ISurface surface) : base
	(
		new Tumbleweed._Enumerable.Lazy.SelectedByExpression<IPolygon>(
			new PolygonsOfSurface(surface),
			polygon => new LazyPolygon(polygon))
	)
	{
	}
}