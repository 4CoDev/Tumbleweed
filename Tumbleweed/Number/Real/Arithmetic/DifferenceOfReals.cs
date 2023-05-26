using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real.Binary.Singles.Arithmetics;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Arithmetic;

public sealed class DifferenceOfReals : RealEnvelope
{
	public DifferenceOfReals(params IReal[] reals) : this
	(
		new EnumerableWithElements<IReal>(reals)
	)
	{
	}
	
	public DifferenceOfReals(IEnumerable<IReal> real) : base
	(
		new RealFromSingle(
			new DifferenceOfSingles(
				new SinglesFromReals(real)))
	)
	{
	}
}