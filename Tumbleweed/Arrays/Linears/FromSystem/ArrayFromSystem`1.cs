using Tumbleweed.Enumerables.FromSystem.FromArray;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.FromSystem;

public sealed class ArrayFromSystem<T> : ArrayEnvelope<T>
{
	public ArrayFromSystem(params T[] array) : this
	(
		new ScalarOfValue<T[]>(array)
	)
	{
	}
	
	public ArrayFromSystem(IScalar<T[]> array) : base
	(
		new ArrayFromEnumerable<T>(
			new EnumerableFromLinear<T>(array)))
	{
	}
}