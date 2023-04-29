using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;

public sealed class LargestOfSingles : ScalarEnvelope<Single>
{
	public LargestOfSingles(params IScalar<Single>[] singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public LargestOfSingles(IEnumerable<IScalar<Single>> singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public LargestOfSingles(params Single[] singles) : this
	(
		new EnumerableWithElements<Single>(singles)
	)
	{
	}

	public LargestOfSingles(IEnumerable<Single> singles) : base
	(
		new ValueOfFunction<Single>(singles.Max)
	)
	{
	}
}