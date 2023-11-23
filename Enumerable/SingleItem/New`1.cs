using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Enumerable.SingleItem;

public sealed class New<T> : Enumerable::Envelope<T>
{
	public New(T value) : base
	(
		new Enumerable::Function.Result<T>(
			() => new T[] { value })
	)
	{
	}
}