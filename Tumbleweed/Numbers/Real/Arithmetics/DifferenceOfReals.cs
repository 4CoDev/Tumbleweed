using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Arithmetics;

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
				new SinglesFromFractionals(real)))
	)
	{
	}
}