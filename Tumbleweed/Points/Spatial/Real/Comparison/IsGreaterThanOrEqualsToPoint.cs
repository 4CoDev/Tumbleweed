using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

namespace Tumbleweed.Points.Spatial.Real.Comparison;

public sealed class IsGreaterThanOrEqualsToPoint : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToPoint
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AndOfBooleans(
			new IsGreaterThanOrEqualsToX(first, second),
			new IsGreaterThanOrEqualsToY(first, second),
			new IsGreaterThanOrEqualsToZ(first, second))
	)
	{
	}
}