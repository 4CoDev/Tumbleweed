using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable;

public sealed class ScalarsOfValues<T>
	: EnumerableEnvelope<IScalar<T>>
{
	public ScalarsOfValues(IEnumerable<T> values) : base
	(
		new SelectedByExpression<T, IScalar<T>>
		(
			values,
			value => new ScalarValue<T>(value)
		)
	)
	{
	}
}