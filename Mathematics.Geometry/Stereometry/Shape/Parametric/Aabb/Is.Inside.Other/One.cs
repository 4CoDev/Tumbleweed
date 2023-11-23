using Godot;
using Boolean = Tumbleweed.Mathematics.Boolean;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;
using Comparison = Tumbleweed.Mathematics.Comparison.Boolean;
using Tumbleweed.Mathematics.Comparison.Vector.Spatial.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Is.Inside.Other;

public sealed class One : Boolean::Envelope
{
	public One
	(
		Aabb::Any @internal,
		Aabb::Any external
	) : base
	(
		new Comparison::Both.Are.True(
			new IsGreaterThanOrEqualsToPoint(
				new Point.A.Actual(@internal),
				new Point.A.Actual(external)),
			new IsLessThanOrEqualsToPoint(
				new Point.B.Actual(@internal),
				new Point.B.Actual(external)))
	)
	{
	}
}