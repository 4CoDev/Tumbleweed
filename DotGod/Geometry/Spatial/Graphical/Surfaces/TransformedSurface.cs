using DotGod.Geometry.Spatial.Graphical.Polygons;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces;

public sealed class TransformedSurface : SurfaceEnvelope
{
	public TransformedSurface
	(
		ISurface surface,
		IScalar<Transform3D> transform
	) : base
	(
		new SurfaceWithValues(
			new TransformedPolygons(surface.Polygons, transform),
			surface.Material)
	)
	{
	}
}