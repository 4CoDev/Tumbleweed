using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Binaries.OfSystem.Singles.Arithmetics;

public sealed class SumOfSingles : ScalarEnvelope<float>
{
	public SumOfSingles(params IScalar<float>[] singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public SumOfSingles(IEnumerable<IScalar<float>> singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public SumOfSingles(params float[] singles) : this
	(
		new EnumerableWithElements<float>(singles)
	)
	{
	}

	public SumOfSingles(IEnumerable<float> singles) : base
	(
		new AggregatedByExpression<float>(singles, 0, Expression)
	)
	{
	}

	private static float Expression(float augend, float addend)
	{
		return augend + addend;
	}
}