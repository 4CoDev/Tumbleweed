using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

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