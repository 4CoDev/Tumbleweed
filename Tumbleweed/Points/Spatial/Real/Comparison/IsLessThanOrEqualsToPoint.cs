using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

namespace Tumbleweed.Points.Spatial.Real.Comparison;

public sealed class IsLessThanOrEqualsToPoint : BooleanEnvelope
{
	public IsLessThanOrEqualsToPoint
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AndOfBooleans(
			new IsLessThanOrEqualsToX(first, second),
			new IsLessThanOrEqualsToY(first, second),
			new IsLessThanOrEqualsToZ(first, second))
	)
	{
	}
}