using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Fractional.Planar.Arithmetics;

public sealed class SumOfPlanars : PlanarEnvelope<IFractional>
{
	public SumOfPlanars(params IPlanar<IFractional>[] planars) : this
	(
		new List<IPlanar<IFractional>>(planars)
	)
	{
	}

	public SumOfPlanars(IEnumerable<IPlanar<IFractional>> planars) : this
	(
		new List<IPlanar<IFractional>>(planars)
	)
	{
	}
	
	public SumOfPlanars(ICollection<IPlanar<IFractional>> planars) : base
	(
		new PlanarWithValues<IFractional>(
			new SumOfFractionals(new XOfPlanars(planars)),
			new SumOfFractionals(new YOfPlanars(planars)))
	)
	{
	}
}