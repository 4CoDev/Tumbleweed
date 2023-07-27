using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public sealed class TransformedSurface : SurfaceEnvelope
{
	public TransformedSurface
	(
		ISurface surface,
		Any<Transform3D> transform
	) : base
	(
		new SurfaceWithValues(
			new TransformedPolygons(surface.Polygons, transform),
			surface.Material)
	)
	{
	}
}