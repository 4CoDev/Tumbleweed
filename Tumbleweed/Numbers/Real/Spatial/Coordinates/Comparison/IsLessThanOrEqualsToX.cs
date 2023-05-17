using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsLessThanOrEqualsToX : BooleanEnvelope
{
	public IsLessThanOrEqualsToX
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsLessThanX(first, second),
			new IsEqualsToX(first, second))
	)
	{
	}
}