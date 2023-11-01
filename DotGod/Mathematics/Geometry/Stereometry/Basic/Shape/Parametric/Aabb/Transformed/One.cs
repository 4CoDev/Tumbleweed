using Godot;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.B.Actual;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Parametric.Aabb.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any space,
		Transform3D transform
	) : this
	(
		space,
		new Value<Transform3D>(transform)
	)
	{
	}
	
	public One
	(
		Any space,
		Any<Transform3D> transform
	) : base
	(
		new Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.With.Points.One(
			new Vector.Spatial.Tumbleweed.Transformed.One(
    new Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual(space), 
			transform),
			new Vector.Spatial.Tumbleweed.Transformed.One(new Actual(space), transform))
	)
	{
	}
}