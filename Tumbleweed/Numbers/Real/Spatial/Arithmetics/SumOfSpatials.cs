using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class SumOfPoints : PointEnvelope<IReal>
{
	public SumOfPoints
	(
		params IPoint<IReal>[] spatials
	) : this
	(
		new List<IPoint<IReal>>(spatials)
	)
	{
	}

	public SumOfPoints
	(
		IEnumerable<IPoint<IReal>> spatials
	) : this
	(
		new List<IPoint<IReal>>(spatials)
	)
	{
	}
	
	public SumOfPoints
	(
		ICollection<IPoint<IReal>> spatials
	) : base
	(
		new PointWithCoordinates<IReal>(
			new SumOfReals(new XOfSpatials(spatials)),
			new SumOfReals(new YOfSpatials(spatials)),
			new SumOfReals(new ZOfSpatials(spatials)))
	)
	{
	}
}