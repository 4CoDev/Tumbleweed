using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanOrEqualsToY : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToY
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsGreaterThanY(first, second),
			new IsEqualsToY(first, second))
	)
	{
	}
}