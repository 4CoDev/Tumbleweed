using Tumbleweed.Scalar.Immutable.Function.Result;
using Enumerable = Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Enumerable;

public sealed class Appended<T> : Enumerable::Envelope<T>
{
	public Appended
	(
		IEnumerable<T> enumerable,
		T value
	) : base
	(
		new Enumerable::Scalar.Value<T>(
			new Actual<IEnumerable<T>>(
				() => enumerable.Append(value)))
	)
	{
	}
}