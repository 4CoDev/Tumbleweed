using Tumbleweed.Boolean.Comparison.Both.Are;
using Tumbleweed.Point.Spatial.Implementation.Real.Comparison;
using Actual = Tumbleweed.Geometry.Spatial.Aabb.Point.B.Actual;

namespace Tumbleweed.Geometry.Spatial.Aabb.Is.Inside.Other;

public sealed class One : Tumbleweed.Boolean.Envelope
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