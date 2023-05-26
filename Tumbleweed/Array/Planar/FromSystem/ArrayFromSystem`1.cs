using Tumbleweed.Array.Planar.Element.FromSystem;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Scalar;

namespace Tumbleweed.Array.Planar.FromSystem;

public sealed class ArrayFromSystem<T> : IArray<T>
{
	public ArrayFromSystem(T[,] array) : this
	(
		new ScalarValue<T[,]>(array)
	)
	{
	}

	public ArrayFromSystem(IScalar<T[,]> array) =>
		this.array = array;

	public T this[IEnumerable<INatural> indices]
	{
		get => new ElementOfArray<T>(array, indices).Value;
		set => new ElementOfArray<T>(array, indices).Value = value;
	}

	public IEnumerable<INatural> Size =>
		new SizeOfArray<T>(array);
	
	private readonly IScalar<T[,]> array;
}