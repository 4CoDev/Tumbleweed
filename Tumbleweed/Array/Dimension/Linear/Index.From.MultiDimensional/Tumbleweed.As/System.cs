using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property;
using System = System;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using Integer = Tumbleweed.Mathematics.Number.Integer.System.Medium;

namespace Tumbleweed.Array.Dimension.Linear.Index.From.MultiDimensional.Tumbleweed.As;

public sealed class System : global::Tumbleweed.Property.Output.Envelope<System::Int32>
{
	public System
	(
		SCG::IEnumerable<Any> indices,
		SCG::IEnumerable<Any> dimensions
	) : base
	(
		new MultiDimensional.System.As.System(
			new Multiple(indices),
			new Multiple(dimensions))
	)
	{
	}
}