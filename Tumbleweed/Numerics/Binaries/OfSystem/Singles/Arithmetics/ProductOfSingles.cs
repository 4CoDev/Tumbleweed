using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Binaries.OfSystem.Singles.Arithmetics;

public sealed class ProductOfSingles : ScalarEnvelope<float>
{
	public ProductOfSingles(params IScalar<float>[] singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public ProductOfSingles(IEnumerable<IScalar<float>> singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public ProductOfSingles(params float[] singles) : this
	(
		new EnumerableWithElements<float>(singles)
	)
	{
	}
	
	public ProductOfSingles(IEnumerable<float> singles) : base
	(
		new AggregatedByExpression<float>(singles, 0, Expression)
	)
	{
	}

	private static float Expression(float multiplicand, float multiplier)
	{
		return multiplicand * multiplier;
	}
}