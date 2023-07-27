using Scalar = Tumbleweed.Scalar;
using System = System;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Length;

public sealed class System<T> : Scalar::Envelope<System::Int32>
{
	public System(SCG::IEnumerable<T> enumerable) : base
	(
		new Scalar::Function.Result<System::Int32>(
			enumerable.Count)
	)
	{
	}
}