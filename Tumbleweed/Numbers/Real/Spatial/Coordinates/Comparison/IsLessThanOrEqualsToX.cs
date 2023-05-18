using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

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