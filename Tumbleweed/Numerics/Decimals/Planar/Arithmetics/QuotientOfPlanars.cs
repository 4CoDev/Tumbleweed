using Tumbleweed.Numerics.Decimals.Arithmetics;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Decimals.Planar.Arithmetics;

public sealed class QuotientOfPlanars : PlanarEnvelope<IDecimal>
{
	public QuotientOfPlanars(params IPlanar<IDecimal>[] planars) : this
	(
		new List<IPlanar<IDecimal>>(planars)
	)
	{
	}

	public QuotientOfPlanars(IEnumerable<IPlanar<IDecimal>> planars) : this
	(
		new List<IPlanar<IDecimal>>(planars)
	)
	{
	}
	
	public QuotientOfPlanars(ICollection<IPlanar<IDecimal>> planars) : base
	(
		new PlanarWithValues<IDecimal>(
			new QuotientOfDecimals(new XOfPlanars(planars)),
			new QuotientOfDecimals(new YOfPlanars(planars)))
	)
	{
	}
}