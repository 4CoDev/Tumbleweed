using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Tumbleweed.Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

public sealed class LazyPolygonsOfSurface : Envelope<IPolygon>
{
	public LazyPolygonsOfSurface(ISurface surface) : base
	(
		new Tumbleweed.Enumerable.Lazy.Selected<IPolygon>(
			new PolygonsOfSurface(surface),
			polygon => new LazyPolygon(polygon))
	)
	{
	}
}