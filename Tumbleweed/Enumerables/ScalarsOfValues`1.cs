using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class ScalarsOfValues<T>
	: EnumerableEnvelope<IScalar<T>>
{
	public ScalarsOfValues(IEnumerable<T> values) : base
	(
		new SelectedByExpression<T, IScalar<T>>
		(
			values,
			value => new ScalarOfValue<T>(value)
		)
	)
	{
	}
}