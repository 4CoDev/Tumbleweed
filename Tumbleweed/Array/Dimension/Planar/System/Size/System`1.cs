using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Array.Dimension.Planar.System.Size;

public sealed class System<T> : Enumerable::Envelope<System::Int32>
{
	public System(T[,] array) : this
	(
		new Scalar::Of.Value<T[,]>(array)
	)
	{
	}
	
	public System(Scalar::Any<T[,]> array) : base
	(
		new Enumerable::Item.Every.Function.Result<System::Int32>(
			() => array.Value.GetLength(0),
			() => array.Value.GetLength(1))
	)
	{
	}
}