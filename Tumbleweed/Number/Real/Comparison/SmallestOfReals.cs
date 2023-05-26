using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real.Binary.Singles.Comparison;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Comparison;

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