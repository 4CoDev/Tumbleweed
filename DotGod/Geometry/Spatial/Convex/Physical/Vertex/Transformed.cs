using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Point = DotGod.Point.Spatial;

namespace DotGod.Geometry.Spatial.Convex.Physical.Vertex;

public sealed class Transformed : Vertex::Envelope
{
	public Transformed
	(
		Vertex::Any vertex,
		Scalar::Any<Godot::Transform3D> transform
	) : base
	(
		new Vertex::With.Translation.One(
			new Point::Transformed.One(
				new Vertex::Translation.One(vertex),
				transform))
	)
	{
	}
}