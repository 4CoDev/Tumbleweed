using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromEnumerable;

namespace Tumbleweed.Number.Real.Binary.Singles.Arithmetics;

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