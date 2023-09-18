using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Point = DotGod.Point.Spatial;

namespace DotGod.Geometry.Spatial.Basic.Vertex.Transformed;

public sealed class One : Vertex::Envelope
{
	public One
	(
		Vertex::Any vertex,
		Godot::Transform3D transform
	) : this
	(
		vertex,
		new Scalar::With.Value<Godot::Transform3D>(transform)
	)
	{
	}
	
	public One
	(
		Vertex::Any vertex,
		Scalar::Any<Godot::Transform3D> transform
	) : base
	(
		new Vertex::With.Translation.One(
			new Point::Transformed.One(
				new Tumbleweed.Geometry.Spatial.Vertex.Member.Translation.One(vertex),
				transform))
	)
	{
	}
}