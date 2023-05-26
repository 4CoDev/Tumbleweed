using Tumbleweed._Boolean;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsLessThanY : BooleanEnvelope
{
	public IsLessThanY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new YOfPoint(first),
			new YOfPoint(second))
	)
	{
	}
}