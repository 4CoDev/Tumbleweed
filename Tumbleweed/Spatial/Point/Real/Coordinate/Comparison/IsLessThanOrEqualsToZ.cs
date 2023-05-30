using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Number.Real;

namespace Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

public sealed class IsLessThanOrEqualsToZ : BooleanEnvelope
{
	public IsLessThanOrEqualsToZ
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsLessThanZ(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}