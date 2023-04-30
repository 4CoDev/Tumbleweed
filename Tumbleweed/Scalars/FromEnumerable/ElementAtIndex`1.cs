using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;

namespace Tumbleweed.Scalars.FromEnumerable;

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