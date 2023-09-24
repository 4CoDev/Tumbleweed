using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison;

public sealed class Largest : Tumbleweed.Scalar.Immutable.Envelope<System::Single>
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