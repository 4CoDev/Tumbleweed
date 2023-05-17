using DotGod.Geometry.Spatial.Graphical.Materials;
using DotGod.Geometry.Spatial.Graphical.Polygons;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces;

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