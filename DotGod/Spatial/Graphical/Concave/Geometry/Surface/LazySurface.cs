using DotGod.Spatial.Graphical.Concave.Geometry._Material;
using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

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