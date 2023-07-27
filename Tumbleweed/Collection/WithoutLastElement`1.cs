using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace Tumbleweed.Collection;

public sealed class WithoutLastElement<T> : Envelope<T>
{
	public WithoutLastElement(ICollection<T> collection) : base
	(
		new Result<T>(
			() => new List<T>(
				collection.Take(
					collection.Count - 1)))
	)
	{
	}
}