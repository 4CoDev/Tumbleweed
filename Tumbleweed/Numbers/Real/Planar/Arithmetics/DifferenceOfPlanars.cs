using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar.Arithmetics;

public sealed class DifferenceOfPoints : PointEnvelope<IReal>
{
	public DifferenceOfPoints(params IPoint<IReal>[] planars) : this
	(
		new List<IPoint<IReal>>(planars)
	)
	{
	}

	public DifferenceOfPoints(IEnumerable<IPoint<IReal>> planars) : this
	(
		new List<IPoint<IReal>>(planars)
	)
	{
	}
	
	public DifferenceOfPoints(ICollection<IPoint<IReal>> planars) : base
	(
		new PointWithCoordinates<IReal>(
			new DifferenceOfReals(new XOfPlanars(planars)),
			new DifferenceOfReals(new YOfPlanars(planars)))
	)
	{
	}
}