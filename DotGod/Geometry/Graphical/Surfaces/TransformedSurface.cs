using DotGod.Geometry.Graphical.Polygons;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Surfaces;

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