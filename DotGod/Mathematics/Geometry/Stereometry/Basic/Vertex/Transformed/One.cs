using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;
using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Vertex.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any vertex,
		Godot::Transform3D transform
	) : this
	(
		vertex,
		new Property::With.Value<Godot::Transform3D>(transform)
	)
	{
	}
	
	public One
	(
		Any vertex,
		Property::Any<Godot::Transform3D> transform
	) : base
	(
		new Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.With.Translation.One(
			new Vector.Spatial.Tumbleweed.Transformed.One(
				new Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation.One(vertex),
				transform))
	)
	{
	}
}