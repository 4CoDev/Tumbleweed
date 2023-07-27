using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic;

public sealed class AbsoluteDifferenceOfX : Envelope
{
	public AbsoluteDifferenceOfX
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new XOfPoint(first),
			new XOfPoint(second))
	)
	{
	}
}