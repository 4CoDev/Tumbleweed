using Scalar = Tumbleweed.Scalar;
using System = System;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;
using Integer = Tumbleweed.Number.Integer.System.Medium;

namespace Tumbleweed.Array.Dimension.Linear.Index.From.MultiDimensional.Tumbleweed.As;

public sealed class System : Scalar::Envelope<System::Int32>
{
	public System
	(
		SCG::IEnumerable<Natural::Any> indices,
		SCG::IEnumerable<Natural::Any> dimensions
	) : base
	(
		new MultiDimensional.System.As.System(
			new Integer::From.Natural.Tumbleweed.Multiple(indices),
			new Integer::From.Natural.Tumbleweed.Multiple(dimensions))
	)
	{
	}
}