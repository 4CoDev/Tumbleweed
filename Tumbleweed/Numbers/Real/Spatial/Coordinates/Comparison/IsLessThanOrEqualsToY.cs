using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

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