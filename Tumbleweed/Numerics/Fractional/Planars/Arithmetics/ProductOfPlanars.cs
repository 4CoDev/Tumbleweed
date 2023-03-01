using Tumbleweed.Numerics.Fractional.Arithmetics;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Fractional.Planars.Arithmetics;

public sealed class ProductOfPlanars : PlanarEnvelope<IFractional>
{
	public ProductOfPlanars(params IPlanar<IFractional>[] planars) : this
	(
		new List<IPlanar<IFractional>>(planars)
	)
	{
	}

	public ProductOfPlanars(IEnumerable<IPlanar<IFractional>> planars) : this
	(
		new List<IPlanar<IFractional>>(planars)
	)
	{
	}
	
	public ProductOfPlanars(ICollection<IPlanar<IFractional>> planars) : base
	(
		new PlanarWithValues<IFractional>(
			new ProductOfFractionals(new XOfPlanars(planars)),
			new ProductOfFractionals(new YOfPlanars(planars)))
	)
	{
	}
}