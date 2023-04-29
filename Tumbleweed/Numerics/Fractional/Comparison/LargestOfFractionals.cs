using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional.FromSystem;

namespace Tumbleweed.Numerics.Fractional.Comparison;

public sealed class LargestOfFractionals : FractionalEnvelope
{
	public LargestOfFractionals(params IFractional[] numbers) : this
	(
		new EnumerableWithElements<IFractional>(numbers)
	)
	{
	}
	
	public LargestOfFractionals(IEnumerable<IFractional> numbers) : base
	(
		new FractionalFromSingle(
			new LargestOfSingles(
				new SinglesFromFractionals(numbers)))
	)
	{
	}
}