using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromSystem;

public sealed class FractionalsFromSingles : EnumerableEnvelope<IFractional>
{
	public FractionalsFromSingles(IEnumerable<IScalar<float>> singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public FractionalsFromSingles(IEnumerable<float> singles) : base
	(
		new SelectedByExpression<float, IFractional>(
			singles,
			single => new FractionalFromSingle(single))
	)
	{
	}
}