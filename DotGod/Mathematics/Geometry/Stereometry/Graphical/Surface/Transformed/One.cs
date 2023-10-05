using Godot;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface.Transformed;

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