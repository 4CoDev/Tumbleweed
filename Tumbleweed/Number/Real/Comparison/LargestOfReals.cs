using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real.Binary.Singles.Comparison;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Comparison;

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