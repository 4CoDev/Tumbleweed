using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromEnumerable;

namespace Tumbleweed.Number.Real.Binary.Singles.Arithmetics;

public sealed class QuotientOfSingles : ScalarEnvelope<Single>
{
	public QuotientOfSingles(params IScalar<Single>[] singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public QuotientOfSingles(IEnumerable<IScalar<Single>> singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public QuotientOfSingles(params Single[] singles) : this
	(
		new EnumerableWithElements<Single>(singles)
	)
	{
	}

	public QuotientOfSingles(IEnumerable<Single> singles) : base
	(
		new AggregatedByExpression<Single>(singles, 0, Expression)
	)
	{
	}

	private static Single Expression(Single dividend, Single divisor)
	{
		return dividend / divisor;
	}
}