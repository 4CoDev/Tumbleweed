using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;

public sealed class SmallestOfSingles : ScalarEnvelope<Single>
{
	public SmallestOfSingles(params IScalar<Single>[] singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public SmallestOfSingles(IEnumerable<IScalar<Single>> singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public SmallestOfSingles(params Single[] singles) : this
	(
		new EnumerableWithElements<Single>(singles)
	)
	{
	}

	public SmallestOfSingles(IEnumerable<Single> singles) : base
	(
		new ValueOfFunction<Single>(singles.Min)
	)
	{
	}
}