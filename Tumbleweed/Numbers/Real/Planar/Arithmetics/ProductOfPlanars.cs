using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real.Arithmetics;

namespace Tumbleweed.Numbers.Real.Planar.Arithmetics;

public sealed class ProductOfPlanars : PlanarEnvelope<IReal>
{
	public ProductOfPlanars(params IPlanar<IReal>[] planars) : this
	(
		new List<IPlanar<IReal>>(planars)
	)
	{
	}

	public ProductOfPlanars(IEnumerable<IPlanar<IReal>> planars) : this
	(
		new List<IPlanar<IReal>>(planars)
	)
	{
	}
	
	public ProductOfPlanars(ICollection<IPlanar<IReal>> planars) : base
	(
		new PlanarWithValues<IReal>(
			new ProductOfReals(new XOfPlanars(planars)),
			new ProductOfReals(new YOfPlanars(planars)))
	)
	{
	}
}