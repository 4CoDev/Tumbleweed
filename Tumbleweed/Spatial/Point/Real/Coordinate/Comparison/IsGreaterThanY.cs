using Tumbleweed._Boolean;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;

namespace Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

public sealed class IsGreaterThanY : BooleanEnvelope
{
	public IsGreaterThanY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsGreaterThanFractional(
			new YOfPoint(first),
			new YOfPoint(second))
	)
	{
	}
}