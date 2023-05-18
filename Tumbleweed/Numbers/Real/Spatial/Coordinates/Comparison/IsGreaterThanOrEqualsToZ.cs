using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

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