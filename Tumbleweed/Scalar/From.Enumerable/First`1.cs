using Tumbleweed.Scalar.Function;

namespace Tumbleweed.Scalar.From.Enumerable;

public sealed class First<T> : Scalar.Envelope<T>
{
	public First(IEnumerable<T> enumerable) : base
	(
		new Function.Result<T>(
			enumerable.First)
	)
	{
	}
}