using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Fractional.Binaries.Singles.Arithmetics;

public sealed class SumOfSingles : ScalarEnvelope<Single>
{
	public SumOfSingles(params IScalar<Single>[] singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public SumOfSingles(IEnumerable<IScalar<Single>> singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public SumOfSingles(params Single[] singles) : this
	(
		new EnumerableWithElements<Single>(singles)
	)
	{
	}

	public SumOfSingles(IEnumerable<Single> singles) : base
	(
		new AggregatedByExpression<Single>(singles, 0, Expression)
	)
	{
	}

	private static Single Expression(Single augend, Single addend)
	{
		return augend + addend;
	}
}