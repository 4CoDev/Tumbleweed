using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar.Arithmetics;

public sealed class QuotientOfPlanars : PlanarEnvelope<IReal>
{
	public QuotientOfPlanars(params IPlanar<IReal>[] planars) : this
	(
		new List<IPlanar<IReal>>(planars)
	)
	{
	}

	public QuotientOfPlanars(IEnumerable<IPlanar<IReal>> planars) : this
	(
		new List<IPlanar<IReal>>(planars)
	)
	{
	}
	
	public QuotientOfPlanars(ICollection<IPlanar<IReal>> planars) : base
	(
		new PlanarWithValues<IReal>(
			new QuotientOfReals(new XOfPlanars(planars)),
			new QuotientOfReals(new YOfPlanars(planars)))
	)
	{
	}
}