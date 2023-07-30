using Mutable = Tumbleweed.Scalar.Mutable;
using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Array.Dimension.Linear.System.Item.At.Index;

public sealed class System<T> : Mutable::Any<T>
{
	public System
	(
		Immutable::Any<T[]> array,
		Immutable::Any<System::Int32> index
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

	private readonly Immutable::Any<T[]> array;
	
	private readonly Immutable::Any<System::Int32> index;
}