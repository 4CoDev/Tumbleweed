using DotGod.Geometry.Spatial.Graphical._Material;
using DotGod.Geometry.Spatial.Graphical.Polygon;

namespace DotGod.Geometry.Spatial.Graphical.Surface;

public sealed class LazySurface : SurfaceEnvelope
{
	public LazySurface(ISurface surface) : base
	(
		new SurfaceWithValues(
			new LazyPolygonsOfSurface(surface),
			new LazyMaterialOfSurface(surface))
	)
	{
	}
}