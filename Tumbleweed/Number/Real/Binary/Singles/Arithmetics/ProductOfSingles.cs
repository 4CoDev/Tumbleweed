using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromEnumerable;

namespace Tumbleweed.Number.Real.Binary.Singles.Arithmetics;

public sealed class ProductOfSingles : ScalarEnvelope<Single>
{
	public ProductOfSingles(params IScalar<Single>[] singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public ProductOfSingles(IEnumerable<IScalar<Single>> singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public ProductOfSingles(params Single[] singles) : this
	(
		new EnumerableWithElements<Single>(singles)
	)
	{
	}
	
	public ProductOfSingles(IEnumerable<Single> singles) : base
	(
		new AggregatedByExpression<Single>(singles, 0, Expression)
	)
	{
	}

	private static Single Expression(Single multiplicand, Single multiplier)
	{
		return multiplicand * multiplier;
	}
}