using Tumbleweed.Scalar.Immutable.Function.Result;
using Scalar = Tumbleweed.Scalar;
using System = System;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Length;

public sealed class System<T> : Tumbleweed.Scalar.Immutable.Envelope<System::Int32>
{
	public System(SCG::IEnumerable<T> enumerable) : base
	(
		new Actual<System::Int32>(
			enumerable.Count)
	)
	{
	}
}