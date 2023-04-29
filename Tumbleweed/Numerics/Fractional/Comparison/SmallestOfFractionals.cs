using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional.FromSystem;

namespace Tumbleweed.Numerics.Fractional.Comparison;

public sealed class SmallestOfFractionals : FractionalEnvelope
{
	public SmallestOfFractionals(params IFractional[] numbers) : this
	(
		new EnumerableWithElements<IFractional>(numbers)
	)
	{
	}
	
	public SmallestOfFractionals(IEnumerable<IFractional> numbers) : base
	(
		new FractionalFromSingle(
			new SmallestOfSingles(
				new SinglesFromFractionals(numbers)))
	)
	{
	}
}