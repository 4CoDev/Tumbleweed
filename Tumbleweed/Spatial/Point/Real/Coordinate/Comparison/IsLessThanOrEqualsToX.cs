using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Number.Real;

namespace Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

public sealed class IsLessThanOrEqualsToX : BooleanEnvelope
{
	public IsLessThanOrEqualsToX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsLessThanX(first, second),
			new IsEqualsToX(first, second))
	)
	{
	}
}