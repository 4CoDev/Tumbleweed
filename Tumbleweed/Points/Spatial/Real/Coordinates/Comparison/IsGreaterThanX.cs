using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Comparison;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

public sealed class IsGreaterThanX : BooleanEnvelope
{
	public IsGreaterThanX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsGreaterThanFractional(
			new XOfPoint(first),
			new XOfPoint(second))
	)
	{
	}
}