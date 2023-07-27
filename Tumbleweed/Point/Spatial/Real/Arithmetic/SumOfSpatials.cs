using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.With.Coordinates;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic;

public sealed class SumOfPoints : Envelope<Any>
{
	public SumOfPoints
	(
		params Any<Any>[] spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}

	public SumOfPoints
	(
		IEnumerable<Any<Any>> spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}
	
	public SumOfPoints
	(
		ICollection<Any<Any>> spatials
	) : base
	(
		new Unique<Any>(
			new SumOfReals(new XOfPoints(spatials)),
			new SumOfReals(new YOfPoints(spatials)),
			new SumOfReals(new ZOfPoints(spatials)))
	)
	{
	}
}