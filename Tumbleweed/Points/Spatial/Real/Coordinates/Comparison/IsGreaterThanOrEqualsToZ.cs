using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

public sealed class IsGreaterThanOrEqualsToZ : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToZ
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsGreaterThanZ(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}