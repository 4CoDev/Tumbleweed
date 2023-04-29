using DotGod.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;

namespace DotGod.Geometrics.Graphical.Polygons;

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