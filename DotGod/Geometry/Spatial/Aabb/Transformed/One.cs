using Godot;
using Tumbleweed.Geometry.Spatial.Aabb;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using Actual = Tumbleweed.Geometry.Spatial.Aabb.Point.B.Actual;

namespace DotGod.Geometry.Spatial.Aabb.Transformed;

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
		new Tumbleweed.Geometry.Spatial.Aabb.With.Points.One(
			new DotGod.Point.Spatial.Transformed.One(new Tumbleweed.Geometry.Spatial.Aabb.Point.A.Actual(space), 
			transform),
			new DotGod.Point.Spatial.Transformed.One(new Actual(space), transform))
	)
	{
	}
}