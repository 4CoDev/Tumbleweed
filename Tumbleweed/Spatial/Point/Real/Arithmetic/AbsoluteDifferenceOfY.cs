using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Spatial.Point.Real.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Arithmetic;

public sealed class AbsoluteDifferenceOfY : RealEnvelope
{
	public AbsoluteDifferenceOfY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new YOfPoint(first),
			new YOfPoint(second))
	)
	{
	}
}