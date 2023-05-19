using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

public sealed class IsGreaterThanOrEqualsToY : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsGreaterThanY(first, second),
			new IsEqualsToY(first, second))
	)
	{
	}
}