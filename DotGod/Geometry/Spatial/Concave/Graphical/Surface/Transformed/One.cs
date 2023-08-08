using DotGod.Geometry.Spatial.Concave.Graphical.Surface.With.Members;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Enumerable = DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Transformed.Enumerable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Surface.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any surface,
		Any<Transform3D> transform
	) : base
	(
		new With.Members.One(
			new Graphical.Polygon.Transformed.Enumerable(surface.Polygons, transform),
			surface.Material)
	)
	{
	}
}