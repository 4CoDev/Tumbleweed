using DotGod.Geometry.Spatial.Graphical.Polygon;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface;

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