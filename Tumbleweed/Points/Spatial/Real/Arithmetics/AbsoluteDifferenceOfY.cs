using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Arithmetics;

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