using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real.Arithmetics;

namespace Tumbleweed.Numbers.Real.Planar.Arithmetics;

public sealed class SumOfPlanars : PlanarEnvelope<IReal>
{
	public SumOfPlanars(params IPlanar<IReal>[] planars) : this
	(
		new List<IPlanar<IReal>>(planars)
	)
	{
	}

	public SumOfPlanars(IEnumerable<IPlanar<IReal>> planars) : this
	(
		new List<IPlanar<IReal>>(planars)
	)
	{
	}
	
	public SumOfPlanars(ICollection<IPlanar<IReal>> planars) : base
	(
		new PlanarWithValues<IReal>(
			new SumOfReals(new XOfPlanars(planars)),
			new SumOfReals(new YOfPlanars(planars)))
	)
	{
	}
}