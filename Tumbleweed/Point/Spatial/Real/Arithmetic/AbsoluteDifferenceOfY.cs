using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic;

public sealed class AbsoluteDifferenceOfY : Envelope
{
	public AbsoluteDifferenceOfY
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new YOfPoint(first),
			new YOfPoint(second))
	)
	{
	}
}