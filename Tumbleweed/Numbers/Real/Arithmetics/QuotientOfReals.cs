using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Arithmetics;

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