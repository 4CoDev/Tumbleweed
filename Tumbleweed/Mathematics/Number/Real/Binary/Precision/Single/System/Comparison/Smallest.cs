using Tumbleweed.Enumerable;
using Tumbleweed.Property.Output.Function.Result;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison;

public sealed class Smallest : Tumbleweed.Property.Output.Envelope<System::Single>
{
	public Smallest(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}

	public Smallest(IEnumerable<System::Single> singles) : base
	(
		new Actual<System::Single>(singles.Min)
	)
	{
	}
}