using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real.Binary.Singles.Arithmetics;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Arithmetic;

public sealed class SumOfReals : RealEnvelope
{
	public SumOfReals(params IReal[] reals) : this
	(
		new EnumerableWithElements<IReal>(reals)
	)
	{
	}
	
	public SumOfReals(IEnumerable<IReal> reals) : base
	(
		new RealFromSingle(
			new SumOfSingles(
				new SinglesFromReals(reals)))
	)
	{
	}
}