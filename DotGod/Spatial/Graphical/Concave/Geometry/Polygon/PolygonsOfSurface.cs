using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Tumbleweed._Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

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