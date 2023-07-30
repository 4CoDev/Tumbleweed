using Scalar = Tumbleweed.Scalar;
using System = System;
using SCG = System.Collections.Generic;
using Collection = Tumbleweed.Collection;

namespace Tumbleweed.Array.Dimension.Linear.Index.From.MultiDimensional.System.As;

public sealed class System : global::Tumbleweed.Scalar.Immutable.Envelope<System::Int32>
{
	public System
	(
		SCG::IEnumerable<System::Int32> indices,
		SCG::IEnumerable<System::Int32> dimensions
	) : base
	(
		new Collection::Number.Integer.FromSystem.FlatIndexFromIndices(
			new SCG::List<System::Int32>(indices),
			new SCG::List<System::Int32>(dimensions))
	)
	{
	}
}