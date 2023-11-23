using Property = Tumbleweed.Property;
using System = System;

namespace Tumbleweed.Array.Dimension.Linear.System.Item.At.Index;

public sealed class System<T> : Property::Transput.Any<T>
{
	public System
	(
		Property::Output.Any<T[]> array,
		Property::Output.Any<System::Int32> index
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

	private readonly Property::Output.Any<T[]> array;
	
	private readonly Property::Output.Any<System::Int32> index;
}