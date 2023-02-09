using Tumbleweed.Arrays.FromEnumerable;
using Tumbleweed.Enumerables.FromSystem.FromArray;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Planars.FromSystem;

public sealed class ArrayFromSystem<T> : ArrayEnvelope<T>
{
	public ArrayFromSystem(T[,] array) : this
	(
		new ScalarOfValue<T[,]>(array)
	)
	{
	}
	
	public ArrayFromSystem(IScalar<T[,]> array) : base
	(
		new MultidimensionalArray<T>(
			new EnumerableFromPlanar<T>(array),
			new SizeOfArray<T>(array))
	)
	{
	}
}