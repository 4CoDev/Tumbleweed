using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar.Arithmetics;

public sealed class DifferenceOfPlanars : PlanarEnvelope<IReal>
{
	public DifferenceOfPlanars(params IPlanar<IReal>[] planars) : this
	(
		new List<IPlanar<IReal>>(planars)
	)
	{
	}

	public DifferenceOfPlanars(IEnumerable<IPlanar<IReal>> planars) : this
	(
		new List<IPlanar<IReal>>(planars)
	)
	{
	}
	
	public DifferenceOfPlanars(ICollection<IPlanar<IReal>> planars) : base
	(
		new PlanarWithValues<IReal>(
			new DifferenceOfReals(new XOfPlanars(planars)),
			new DifferenceOfReals(new YOfPlanars(planars)))
	)
	{
	}
}