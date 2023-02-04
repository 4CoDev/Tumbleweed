using Tumbleweed.Numerics.Decimals.Arithmetics;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Decimals.Planars.Arithmetics;

public sealed class SumOfPlanars : PlanarEnvelope<IDecimal>
{
	public SumOfPlanars(params IPlanar<IDecimal>[] planars) : this
	(
		new List<IPlanar<IDecimal>>(planars)
	)
	{
	}

	public SumOfPlanars(IEnumerable<IPlanar<IDecimal>> planars) : this
	(
		new List<IPlanar<IDecimal>>(planars)
	)
	{
	}
	
	public SumOfPlanars(ICollection<IPlanar<IDecimal>> planars) : base
	(
		new PlanarWithValues<IDecimal>(
			new SumOfDecimals(new XOfPlanars(planars)),
			new SumOfDecimals(new YOfPlanars(planars)))
	)
	{
	}
}