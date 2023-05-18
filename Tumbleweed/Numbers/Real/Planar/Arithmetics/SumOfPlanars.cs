using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar.Arithmetics;

public sealed class SumOfPoints : PointEnvelope<IReal>
{
	public SumOfPoints(params IPoint<IReal>[] planars) : this
	(
		new List<IPoint<IReal>>(planars)
	)
	{
	}

	public SumOfPoints(IEnumerable<IPoint<IReal>> planars) : this
	(
		new List<IPoint<IReal>>(planars)
	)
	{
	}
	
	public SumOfPoints(ICollection<IPoint<IReal>> planars) : base
	(
		new PointWithCoordinates<IReal>(
			new SumOfReals(new XOfPlanars(planars)),
			new SumOfReals(new YOfPlanars(planars)))
	)
	{
	}
}