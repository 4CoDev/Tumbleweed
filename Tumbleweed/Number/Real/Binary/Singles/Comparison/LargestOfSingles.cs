using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.Singles.Comparison;

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
		new ResultOfFunction<Single>(singles.Max)
	)
	{
	}
}