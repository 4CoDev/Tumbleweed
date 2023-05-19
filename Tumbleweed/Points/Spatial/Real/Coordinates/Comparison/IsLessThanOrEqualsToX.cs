using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

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