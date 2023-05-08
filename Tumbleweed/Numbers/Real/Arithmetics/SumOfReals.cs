using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Arithmetics;

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