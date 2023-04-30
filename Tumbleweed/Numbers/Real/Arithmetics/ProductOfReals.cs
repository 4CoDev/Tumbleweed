using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Arithmetics;

public sealed class ProductOfReals : RealEnvelope
{
	public ProductOfReals(params IReal[] reals) : this
	(
		new EnumerableWithElements<IReal>(reals)
	)
	{
	}
	
	public ProductOfReals(IEnumerable<IReal> reals) : base
	(
		new RealFromSingle(
			new DifferenceOfSingles(
				new SinglesFromFractionals(reals)))
	)
	{
	}
}