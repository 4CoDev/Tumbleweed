using Tumbleweed.Array;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Array.Element.FromSystem;

namespace Tumbleweed.Spatial.Array.FromSystem;

public sealed class ArrayFromSystem<T> : IArray<T>
{
	public ArrayFromSystem(T[,,] array) : this
	(
		new ScalarValue<T[,,]>(array)
	)
	{
	}

	public ArrayFromSystem(IScalar<T[,,]> array) =>
		this.array = array;

	public T this[IEnumerable<INatural> indices]
	{
		get => new ElementOfArray<T>(array, indices).Value;
		set => new ElementOfArray<T>(array, indices).Value = value;
	}

	public IEnumerable<INatural> Size =>
		new SizeOfArray<T>(array);
	
	private readonly IScalar<T[,,]> array;
}