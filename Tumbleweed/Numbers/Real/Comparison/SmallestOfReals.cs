using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real.Binaries.Singles.Comparison;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Comparison;

public sealed class SmallestOfReals : RealEnvelope
{
	public SmallestOfReals(params IReal[] numbers) : this
	(
		new EnumerableWithElements<IReal>(numbers)
	)
	{
	}
	
	public SmallestOfReals(IEnumerable<IReal> numbers) : base
	(
		new RealFromSingle(
			new SmallestOfSingles(
				new SinglesFromReals(numbers)))
	)
	{
	}
}