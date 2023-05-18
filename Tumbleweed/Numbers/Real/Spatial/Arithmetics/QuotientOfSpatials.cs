using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

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
			new QuotientOfReals(new XOfSpatials(spatials)),
			new QuotientOfReals(new YOfSpatials(spatials)),
			new QuotientOfReals(new ZOfSpatials(spatials)))
	)
	{
	}
}