using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.ToSystem.Ints32;

namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class ScalarAtIndex<T> : IScalar<T>
{
	public ScalarAtIndex(IEnumerable<T> enumerable, IInteger index)
	{
		this.enumerable = enumerable;
		this.index = index;
	}

	public T Value =>
		new FromSystem.ScalarAtIndex<T>(
			enumerable,
			new Int32FromInteger(index)).Value;

	private readonly IEnumerable<T> enumerable;

	private readonly IInteger index;
}