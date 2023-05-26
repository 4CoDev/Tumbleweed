using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real.Binary.Singles.Arithmetics;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Arithmetic;

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
				new SinglesFromReals(reals)))
	)
	{
	}
}