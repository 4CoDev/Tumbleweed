using Tumbleweed.Mathematics.Comparison.Boolean.Both.Are;
using Tumbleweed.Point.Spatial.Real.Comparison;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.B.Actual;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Is.Inside.Other;

public sealed class One : Mathematics.Boolean.Envelope
{
	public One
	(
		Any @internal,
		Any external
	) : base
	(
		new True(
			new IsGreaterThanOrEqualsToPoint(
				new Point.A.Actual(@internal),
				new Point.A.Actual(external)),
			new IsLessThanOrEqualsToPoint(
				new Actual(@internal),
				new Actual(external)))
	)
	{
	}
}