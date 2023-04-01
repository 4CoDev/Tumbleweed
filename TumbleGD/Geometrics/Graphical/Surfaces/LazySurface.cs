using TumbleGD.Geometrics.Graphical.Materials;
using TumbleGD.Geometrics.Graphical.Polygons;

namespace TumbleGD.Geometrics.Graphical.Surfaces;

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