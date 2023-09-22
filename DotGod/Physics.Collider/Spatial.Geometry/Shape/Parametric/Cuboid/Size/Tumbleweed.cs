using DotGod.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid.Godot.Size.Point;
using Godot = Godot;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using GeometryParametric = DotGod.Geometry.Stereometry.Basic.Shape.Parametric;
using ColliderParametric = DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric.Cuboid.Size;

public sealed class Tumbleweed : Point::Generic.Envelope<Real::Any>
{
	public Tumbleweed
	(
		Scalar::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new Actual(
			new ColliderParametric::Cuboid.Value.Godot.Actual(collider))
	)
	{
	}
}