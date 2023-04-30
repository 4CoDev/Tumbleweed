using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsLessThanOrEqualsToY : BooleanEnvelope
{
	public IsLessThanOrEqualsToY
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsLessThanY(first, second),
			new IsEqualsToY(first, second))
	)
	{
	}
}