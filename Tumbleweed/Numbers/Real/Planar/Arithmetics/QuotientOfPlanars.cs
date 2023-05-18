using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar.Arithmetics;

public sealed class QuotientOfPoints : PointEnvelope<IReal>
{
	public QuotientOfPoints(params IPoint<IReal>[] planars) : this
	(
		new List<IPoint<IReal>>(planars)
	)
	{
	}

	public QuotientOfPoints(IEnumerable<IPoint<IReal>> planars) : this
	(
		new List<IPoint<IReal>>(planars)
	)
	{
	}
	
	public QuotientOfPoints(ICollection<IPoint<IReal>> planars) : base
	(
		new PointWithCoordinates<IReal>(
			new QuotientOfReals(new XOfPlanars(planars)),
			new QuotientOfReals(new YOfPlanars(planars)))
	)
	{
	}
}