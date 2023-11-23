using Tumbleweed.Property.Output.Function.Result;
using Property = Tumbleweed.Property;
using System = System;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Length;

public sealed class System<T> : Tumbleweed.Property.Output.Envelope<System::Int32>
{
	public System(SCG::IEnumerable<T> enumerable) : base
	(
		new Actual<System::Int32>(
			enumerable.Count)
	)
	{
	}
}