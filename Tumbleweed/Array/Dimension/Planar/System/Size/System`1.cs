using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With;
using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Property = Tumbleweed.Property;

namespace Tumbleweed.Array.Dimension.Planar.System.Size;

public sealed class System<T> : Enumerable::Envelope<System::Int32>
{
	public System(T[,] array) : this
	(
		new Value<T[,]>(array)
	)
	{
	}
	
	public System(Tumbleweed.Property.Output.Any<T[,]> array) : base
	(
		new Enumerable::Item.Every.Function.Result<System::Int32>(
			() => array.Value.GetLength(0),
			() => array.Value.GetLength(1))
	)
	{
	}
}