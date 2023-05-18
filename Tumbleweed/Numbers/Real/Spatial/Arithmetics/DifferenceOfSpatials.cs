using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class DifferenceOfPoints : PointEnvelope<IReal>
{
	public DifferenceOfPoints
	(
		params IPoint<IReal>[] spatials
	) : this
	(
		new List<IPoint<IReal>>(spatials)
	)
	{
	}

	public DifferenceOfPoints
	(
		IEnumerable<IPoint<IReal>> spatials
	) : this
	(
		new List<IPoint<IReal>>(spatials)
	)
	{
	}
	
	public DifferenceOfPoints
	(
		ICollection<IPoint<IReal>> spatials
	) : base
	(
		new PointWithCoordinates<IReal>(
			new DifferenceOfReals(new XOfSpatials(spatials)),
			new DifferenceOfReals(new YOfSpatials(spatials)),
			new DifferenceOfReals(new ZOfSpatials(spatials)))
	)
	{
	}
}