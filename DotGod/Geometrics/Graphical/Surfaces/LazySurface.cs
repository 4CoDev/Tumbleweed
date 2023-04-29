using DotGod.Geometrics.Graphical.Materials;
using DotGod.Geometrics.Graphical.Polygons;

namespace DotGod.Geometrics.Graphical.Surfaces;

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