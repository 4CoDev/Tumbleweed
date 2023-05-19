using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Arithmetics;

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
			new DifferenceOfReals(new XOfPoints(spatials)),
			new DifferenceOfReals(new YOfPoints(spatials)),
			new DifferenceOfReals(new ZOfPoints(spatials)))
	)
	{
	}
}