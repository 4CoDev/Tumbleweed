using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

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