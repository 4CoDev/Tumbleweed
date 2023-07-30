using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison;

public sealed class Smallest : Tumbleweed.Scalar.Immutable.Envelope<System::Single>
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