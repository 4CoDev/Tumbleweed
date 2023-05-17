using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanOrEqualsToX : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToX
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsGreaterThanX(first, second),
			new IsEqualsToX(first, second))
	)
	{
	}
}