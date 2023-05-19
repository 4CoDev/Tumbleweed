using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

namespace Tumbleweed.Points.Spatial.Real.Comparison;

public sealed class IsEqualsToPoint : BooleanEnvelope
{
	public IsEqualsToPoint
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AndOfBooleans(
			new IsEqualsToX(first, second),
			new IsEqualsToY(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}