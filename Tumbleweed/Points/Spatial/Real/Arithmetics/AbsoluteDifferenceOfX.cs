using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Arithmetics;

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