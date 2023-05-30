using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Spatial.Point.Real.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Arithmetic;

public sealed class AbsoluteDifferenceOfX : RealEnvelope
{
	public AbsoluteDifferenceOfX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new XOfPoint(first),
			new XOfPoint(second))
	)
	{
	}
}