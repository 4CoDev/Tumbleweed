using DotGod.Geometry.Spatial.Graphical.Surface;
using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Polygon;

public sealed class PolygonsOfSurface : EnumerableEnvelope<IPolygon>
{
	public PolygonsOfSurface(ISurface surface) : base
	(
		new EnumerableOfFunction<IPolygon>(
			() => surface.Polygons)
	)
	{
	}
}