using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real.Binaries.Singles.Comparison;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Comparison;

public sealed class LargestOfReals : RealEnvelope
{
	public LargestOfReals(params IReal[] numbers) : this
	(
		new EnumerableWithElements<IReal>(numbers)
	)
	{
	}
	
	public LargestOfReals(IEnumerable<IReal> numbers) : base
	(
		new RealFromSingle(
			new LargestOfSingles(
				new SinglesFromReals(numbers)))
	)
	{
	}
}