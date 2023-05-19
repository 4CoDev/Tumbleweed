using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Arithmetics;

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