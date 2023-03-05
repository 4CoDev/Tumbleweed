using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromSystem;

public sealed class FractionalsFromSingles : EnumerableEnvelope<IFractional>
{
	public FractionalsFromSingles(IEnumerable<IScalar<Single>> singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public FractionalsFromSingles(IEnumerable<Single> singles) : base
	(
		new SelectedByExpression<Single, IFractional>(
			singles,
			single => new FractionalFromSingle(single))
	)
	{
	}
}