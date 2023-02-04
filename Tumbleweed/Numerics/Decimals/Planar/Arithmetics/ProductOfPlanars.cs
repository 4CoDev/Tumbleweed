using Tumbleweed.Numerics.Decimals.Arithmetics;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Decimals.Planar.Arithmetics;

public sealed class ProductOfPlanars : PlanarEnvelope<IDecimal>
{
	public ProductOfPlanars(params IPlanar<IDecimal>[] planars) : this
	(
		new List<IPlanar<IDecimal>>(planars)
	)
	{
	}

	public ProductOfPlanars(IEnumerable<IPlanar<IDecimal>> planars) : this
	(
		new List<IPlanar<IDecimal>>(planars)
	)
	{
	}
	
	public ProductOfPlanars(ICollection<IPlanar<IDecimal>> planars) : base
	(
		new PlanarWithValues<IDecimal>(
			new ProductOfDecimals(new XOfPlanars(planars)),
			new ProductOfDecimals(new YOfPlanars(planars)))
	)
	{
	}
}