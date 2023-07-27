using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

public sealed class PolygonsOfSurface : Envelope<IPolygon>
{
	public PolygonsOfSurface(ISurface surface) : base
	(
		new Result<IPolygon>(
			() => surface.Polygons)
	)
	{
	}
}