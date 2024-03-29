using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;
using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Property = Tumbleweed.Property;

namespace Tumbleweed.Array.Dimension.Spatial.System.Size;

public sealed class System<T> : Enumerable::Envelope<System::Int32>
{
	public System(T[,,] array) : this
	(
		new One<T[,,]>(array)
	)
	{
	}
	
	public System(Tumbleweed.Property.Output.Any<T[,,]> array) : base
	(
		new Enumerable::Item.Every.Function.Result<Int32>(
			() => array.Value.GetLength(0),
			() => array.Value.GetLength(1),
			() => array.Value.GetLength(2))
	)
	{
	}
}