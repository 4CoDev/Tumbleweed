using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.With.Coordinates;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic;

public sealed class DifferenceOfPoints : Envelope<Any>
{
	public DifferenceOfPoints
	(
		params Any<Any>[] spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}

	public DifferenceOfPoints
	(
		IEnumerable<Any<Any>> spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}
	
	public DifferenceOfPoints
	(
		ICollection<Any<Any>> spatials
	) : base
	(
		new Unique<Any>(
			new DifferenceOfReals(new XOfPoints(spatials)),
			new DifferenceOfReals(new YOfPoints(spatials)),
			new DifferenceOfReals(new ZOfPoints(spatials)))
	)
	{
	}
}