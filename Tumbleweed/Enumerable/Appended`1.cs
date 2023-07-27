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
			new Scalar::Function.Result<IEnumerable<T>>(
				() => enumerable.Append(value)))
	)
	{
	}
}