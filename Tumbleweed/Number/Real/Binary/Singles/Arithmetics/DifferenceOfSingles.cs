using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromEnumerable;

namespace Tumbleweed.Number.Real.Binary.Singles.Arithmetics;

public sealed class DifferenceOfSingles : ScalarEnvelope<Single>
{
	public DifferenceOfSingles(params IScalar<Single>[] singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public DifferenceOfSingles(IEnumerable<IScalar<Single>> singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public DifferenceOfSingles(params Single[] singles) : this
	(
		new EnumerableWithElements<Single>(singles)
	)
	{
	}
	
	public DifferenceOfSingles(IEnumerable<Single> singles) : base
	(
		new AggregatedByExpression<Single>(singles, 0, Expression)
	)
	{
	}

	private static Single Expression(Single minuend, Single subtrahend)
	{
		return minuend - subtrahend;
	}
}