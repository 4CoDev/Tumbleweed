using Tumbleweed.Enumerable;
using Tumbleweed.Property.Output.Function.Result;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison;

public sealed class Largest : Tumbleweed.Property.Output.Envelope<System::Single>
{
	public Largest(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}

	public Largest(IEnumerable<System::Single> singles) : base
	(
		new Actual<System::Single>(singles.Max)
	)
	{
	}
}