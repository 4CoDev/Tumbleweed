using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar.Arithmetics;

public sealed class ProductOfPoints : PointEnvelope<IReal>
{
	public ProductOfPoints(params IPoint<IReal>[] planars) : this
	(
		new List<IPoint<IReal>>(planars)
	)
	{
	}

	public ProductOfPoints(IEnumerable<IPoint<IReal>> planars) : this
	(
		new List<IPoint<IReal>>(planars)
	)
	{
	}
	
	public ProductOfPoints(ICollection<IPoint<IReal>> planars) : base
	(
		new PointWithCoordinates<IReal>(
			new ProductOfReals(new XOfPlanars(planars)),
			new ProductOfReals(new YOfPlanars(planars)))
	)
	{
	}
}