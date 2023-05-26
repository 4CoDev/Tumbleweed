using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsLessThanOrEqualsToY : BooleanEnvelope
{
	public IsLessThanOrEqualsToY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsLessThanY(first, second),
			new IsEqualsToY(first, second))
	)
	{
	}
}