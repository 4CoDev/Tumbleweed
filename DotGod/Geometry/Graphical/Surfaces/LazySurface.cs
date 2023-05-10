using DotGod.Geometry.Graphical.Materials;
using DotGod.Geometry.Graphical.Polygons;

namespace DotGod.Geometry.Graphical.Surfaces;

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