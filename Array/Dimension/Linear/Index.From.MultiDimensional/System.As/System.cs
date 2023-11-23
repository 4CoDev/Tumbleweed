using Property = Tumbleweed.Property.Output;
using System = System;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Linear.Index.From.MultiDimensional.System.As;

public sealed class System : global::Tumbleweed.Property.Output.Envelope<System::Int32>
{
	public System
	(
		SCG::IList<System::Int32> indices,
		SCG::IList<System::Int32> dimensions
	) : base
	(
		new Property::Function.Result.Actual<Int32>(
			() => Result(indices, dimensions))
	)
	{
	}

	private static Int32 Result
	(
		IList<Int32> indices,
		IList<Int32> dimensions
	)
	{
		if (indices.Count > dimensions.Count)
			throw new InvalidOperationException(
				"Indices go beyond dimensions.");
		var modifier = 1;
		var result = 0;
		for (var i = 0; i < indices.Count; i++)
		{
			var index = indices[i];
			var dimension = dimensions[i];
			result += index * modifier;
			modifier *= dimension;
		}
		return result;
	}
}