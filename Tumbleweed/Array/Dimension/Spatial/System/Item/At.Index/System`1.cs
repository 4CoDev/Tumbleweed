using Mutable = Tumbleweed.Scalar.Mutable;
using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using System = System;

namespace Tumbleweed.Array.Dimension.Spatial.System.Item.At.Index;

public sealed class System<T> : Mutable::Any<T>
{
	public System
	(
		T[,,] array,
		SCG::IEnumerable<System::Int32> indices
	) : this
	(
		new Immutable::With.Value<T[,,]>(array),
		indices
	)
	{
	}
	
	public System
	(
		Immutable::Any<T[,,]> array,
		SCG::IEnumerable<System::Int32> indices
	) : this
	(
		array,
		new SCG::List<System::Int32>(indices)
	)
	{
	}
	
	public System
	(
		T[,,] array,
		SCG::ICollection<System::Int32> indices
	) : this
	(
		new Immutable::With.Value<T[,,]>(array),
		indices
	)
	{
	}
	
	public System
	(
		Immutable::Any<T[,,]> array,
		SCG::ICollection<System::Int32> indices
	) 
	{
		this.array = array;
		this.indices = indices;
	}
	
	public T Value
	{
		get => array.Value[
			indices.ElementAt(0),
			indices.ElementAt(1),
			indices.ElementAt(2)];

		set => array.Value[
			indices.ElementAt(0),
			indices.ElementAt(1),
			indices.ElementAt(2)] = value;
	}

	private readonly Immutable::Any<T[,,]> array;
	
	private readonly SCG::ICollection<System::Int32> indices;
}