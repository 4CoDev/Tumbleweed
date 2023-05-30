using Tumbleweed._Boolean;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;

namespace Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

public sealed class IsLessThanX : BooleanEnvelope
{
	public IsLessThanX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new XOfPoint(first),
			new XOfPoint(second))
	)
	{
	}
}