using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Implementation.Real.Coordinate;
using Tumbleweed.Point.Spatial.With.Coordinates;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Arithmetic;

public sealed class QuotientOfPoints : Envelope<Any>
{
	public QuotientOfPoints
	(
		params Any<Any>[] spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}

	public QuotientOfPoints
	(
		IEnumerable<Any<Any>> spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}
	
	public QuotientOfPoints
	(
		ICollection<Any<Any>> spatials
	) : base
	(
		new Unique<Any>(
			new QuotientOfReals(new XOfPoints(spatials)),
			new QuotientOfReals(new YOfPoints(spatials)),
			new QuotientOfReals(new ZOfPoints(spatials)))
	)
	{
	}
}