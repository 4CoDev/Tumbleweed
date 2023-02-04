using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Binary.OfSystem.Singles.Arithmetics;

public sealed class QuotientOfSingles : ScalarEnvelope<float>
{
	public QuotientOfSingles(params IScalar<float>[] singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public QuotientOfSingles(IEnumerable<IScalar<float>> singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public QuotientOfSingles(params float[] singles) : this
	(
		new EnumerableWithElements<float>(singles)
	)
	{
	}

	public QuotientOfSingles(IEnumerable<float> singles) : base
	(
		new AggregatedByExpression<float>(singles, 0, Expression)
	)
	{
	}

	private static float Expression(float dividend, float divisor)
	{
		return dividend / divisor;
	}
}