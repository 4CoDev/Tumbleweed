using Tumbleweed.Numerics.Decimals.Arithmetics;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Decimals.Planar.Arithmetics;

public sealed class DifferenceOfPlanars : PlanarEnvelope<IDecimal>
{
	public DifferenceOfPlanars(params IPlanar<IDecimal>[] planars) : this
	(
		new List<IPlanar<IDecimal>>(planars)
	)
	{
	}

	public DifferenceOfPlanars(IEnumerable<IPlanar<IDecimal>> planars) : this
	(
		new List<IPlanar<IDecimal>>(planars)
	)
	{
	}
	
	public DifferenceOfPlanars(ICollection<IPlanar<IDecimal>> planars) : base
	(
		new PlanarWithValues<IDecimal>(
			new DifferenceOfDecimals(new XOfPlanars(planars)),
			new DifferenceOfDecimals(new YOfPlanars(planars)))
	)
	{
	}
}