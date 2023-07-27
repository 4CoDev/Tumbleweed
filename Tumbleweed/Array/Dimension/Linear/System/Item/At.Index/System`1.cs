using Mutable = Tumbleweed.Mutable;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Array.Dimension.Linear.System.Item.At.Index;

public sealed class System<T> : Mutable::Any<T>
{
	public System
	(
		Scalar::Any<T[]> array,
		Scalar::Any<Int32> index
	)
	{
		this.array = array;
		this.index = index;
	}

	public T Value
	{
		get => array.Value[index.Value];
		set => array.Value[index.Value] = value;
	}

	private readonly Tumbleweed.Scalar.Any<T[]> array;
	
	private readonly Tumbleweed.Scalar.Any<Int32> index;
}