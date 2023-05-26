using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;

namespace Tumbleweed.Scalar.FromEnumerable;

public sealed class ElementAtIndex<T> : IScalar<T>
{
	public ElementAtIndex(IEnumerable<T> enumerable, INatural index)
	{
		this.enumerable = enumerable;
		this.index = index;
	}

	public T Value =>
		new FromSystem.ElementAtIndex<T>(
			enumerable,
			new Int32FromNatural(index)).Value;

	private readonly IEnumerable<T> enumerable;

	private readonly INatural index;
}