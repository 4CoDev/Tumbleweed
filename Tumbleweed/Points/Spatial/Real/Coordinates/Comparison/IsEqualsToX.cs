using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Comparison;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

public sealed class IsEqualsToX : BooleanEnvelope
{
	public IsEqualsToX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsEqualsToFractional(
			new XOfPoint(first),
			new XOfPoint(second))
	)
	{
	}
}