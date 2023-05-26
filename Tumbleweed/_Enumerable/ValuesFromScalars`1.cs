using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable;

public sealed class ValuesOfScalars<T> : EnumerableEnvelope<T>
{
	public ValuesOfScalars(IEnumerable<IScalar<T>> enumerable) : base
	(
		new SelectedByExpression<IScalar<T>, T>(
			enumerable,
			scalar => scalar.Value)
	)
	{
	}
}