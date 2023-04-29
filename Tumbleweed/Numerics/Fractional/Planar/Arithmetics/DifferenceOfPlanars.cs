using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Fractional.Planar.Arithmetics;

public sealed class DifferenceOfPlanars : PlanarEnvelope<IFractional>
{
	public DifferenceOfPlanars(params IPlanar<IFractional>[] planars) : this
	(
		new List<IPlanar<IFractional>>(planars)
	)
	{
	}

	public DifferenceOfPlanars(IEnumerable<IPlanar<IFractional>> planars) : this
	(
		new List<IPlanar<IFractional>>(planars)
	)
	{
	}
	
	public DifferenceOfPlanars(ICollection<IPlanar<IFractional>> planars) : base
	(
		new PlanarWithValues<IFractional>(
			new DifferenceOfFractionals(new XOfPlanars(planars)),
			new DifferenceOfFractionals(new YOfPlanars(planars)))
	)
	{
	}
}