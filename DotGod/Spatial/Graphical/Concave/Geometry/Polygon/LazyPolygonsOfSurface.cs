using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Tumbleweed._Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

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