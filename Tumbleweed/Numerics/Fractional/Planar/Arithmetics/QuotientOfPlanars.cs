using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Fractional.Planar.Arithmetics;

public sealed class QuotientOfPlanars : PlanarEnvelope<IFractional>
{
	public QuotientOfPlanars(params IPlanar<IFractional>[] planars) : this
	(
		new List<IPlanar<IFractional>>(planars)
	)
	{
	}

	public QuotientOfPlanars(IEnumerable<IPlanar<IFractional>> planars) : this
	(
		new List<IPlanar<IFractional>>(planars)
	)
	{
	}
	
	public QuotientOfPlanars(ICollection<IPlanar<IFractional>> planars) : base
	(
		new PlanarWithValues<IFractional>(
			new QuotientOfFractionals(new XOfPlanars(planars)),
			new QuotientOfFractionals(new YOfPlanars(planars)))
	)
	{
	}
}