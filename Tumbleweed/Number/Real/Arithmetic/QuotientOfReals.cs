using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real.Binary.Singles.Arithmetics;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Arithmetic;

public sealed class QuotientOfReals : RealEnvelope
{
	public QuotientOfReals(params IReal[] reals) : this
	(
		new EnumerableWithElements<IReal>(reals)
	)
	{
	}
	
	public QuotientOfReals(IEnumerable<IReal> reals) : base
	(
		new RealFromSingle(
			new DifferenceOfSingles(
				new SinglesFromReals(reals)))
	)
	{
	}
}