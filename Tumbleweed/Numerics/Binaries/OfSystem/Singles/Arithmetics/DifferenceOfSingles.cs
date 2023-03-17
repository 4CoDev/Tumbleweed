using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Binaries.OfSystem.Singles.Arithmetics;

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