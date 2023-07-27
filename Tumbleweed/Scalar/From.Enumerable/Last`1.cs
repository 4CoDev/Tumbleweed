using Tumbleweed.Scalar.Function;

namespace Tumbleweed.Scalar.From.Enumerable;

public sealed class Last<T> : Scalar.Envelope<T>
{
	public Last(IEnumerable<T> enumerable) : base
	(
		new Function.Result<T>(
			enumerable.Last)
	)
	{
	}
}