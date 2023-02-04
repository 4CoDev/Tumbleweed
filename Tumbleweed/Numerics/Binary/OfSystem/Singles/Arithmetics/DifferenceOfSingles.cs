using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Binary.OfSystem.Singles.Arithmetics;

public sealed class DifferenceOfSingles : ScalarEnvelope<float>
{
	public DifferenceOfSingles(params IScalar<float>[] singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public DifferenceOfSingles(IEnumerable<IScalar<float>> singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public DifferenceOfSingles(params float[] singles) : this
	(
		new EnumerableWithElements<float>(singles)
	)
	{
	}
	
	public DifferenceOfSingles(IEnumerable<float> singles) : base
	(
		new AggregatedByExpression<float>(singles, 0, Expression)
	)
	{
	}

	private static float Expression(float minuend, float subtrahend)
	{
		return minuend - subtrahend;
	}
}