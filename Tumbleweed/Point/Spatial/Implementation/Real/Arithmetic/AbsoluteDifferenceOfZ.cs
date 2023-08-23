using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Implementation.Real.Coordinate;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Arithmetic;

public sealed class AbsoluteDifferenceOfZ : Envelope
{
	public AbsoluteDifferenceOfZ
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new ZOfPoint(first),
			new ZOfPoint(second))
	)
	{
	}
}