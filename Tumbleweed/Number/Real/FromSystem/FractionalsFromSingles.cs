using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.FromSystem;

public sealed class FractionalsFromSingles : EnumerableEnvelope<IReal>
{
	public FractionalsFromSingles(IEnumerable<IScalar<Single>> singles) : this
	(
		new ValuesOfScalars<Single>(singles)
	)
	{
	}
	
	public FractionalsFromSingles(IEnumerable<Single> singles) : base
	(
		new SelectedByExpression<Single, IReal>(
			singles,
			single => new RealFromSingle(single))
	)
	{
	}
}