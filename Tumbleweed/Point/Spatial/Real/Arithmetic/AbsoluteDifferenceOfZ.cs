using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic;

public sealed class AbsoluteDifferenceOfZ : RealEnvelope
{
	public AbsoluteDifferenceOfZ
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new ZOfPoint(first),
			new ZOfPoint(second))
	)
	{
	}
}