using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Point = DotGod.Point.Spatial;

namespace DotGod.Geometry.Stereometry.Basic.Vertex.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any vertex,
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
		Any vertex,
		Scalar::Any<Godot::Transform3D> transform
	) : base
	(
		new Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.With.Translation.One(
			new Point::Transformed.One(
				new Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation.One(vertex),
				transform))
	)
	{
	}
}