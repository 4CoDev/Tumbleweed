using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class ScalarAtIndex<T> : IScalar<T>
{
	public ScalarAtIndex(IEnumerable<T> enumerable, INaturalInteger index)
	{
		this.enumerable = enumerable;
		this.index = index;
	}

	public T Value =>
		new FromSystem.ScalarAtIndex<T>(
			enumerable,
			new Int32FromNatural(index)).Value;

	private readonly IEnumerable<T> enumerable;

	private readonly INaturalInteger index;
}