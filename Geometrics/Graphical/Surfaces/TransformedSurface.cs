using Godot;
using Tumbleweed.Geometrics.Graphical.Polygons;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.Graphical.Surfaces;

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