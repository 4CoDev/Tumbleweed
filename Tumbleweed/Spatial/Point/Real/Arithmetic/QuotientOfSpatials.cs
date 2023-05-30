using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Spatial.Point.Real.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Arithmetic;

public sealed class QuotientOfPoints : PointEnvelope<IReal>
{
	public QuotientOfPoints
	(
		params IPoint<IReal>[] spatials
	) : this
	(
		new List<IPoint<IReal>>(spatials)
	)
	{
	}

	public QuotientOfPoints
	(
		IEnumerable<IPoint<IReal>> spatials
	) : this
	(
		new List<IPoint<IReal>>(spatials)
	)
	{
	}
	
	public QuotientOfPoints
	(
		ICollection<IPoint<IReal>> spatials
	) : base
	(
		new PointWithCoordinates<IReal>(
			new QuotientOfReals(new XOfPoints(spatials)),
			new QuotientOfReals(new YOfPoints(spatials)),
			new QuotientOfReals(new ZOfPoints(spatials)))
	)
	{
	}
}