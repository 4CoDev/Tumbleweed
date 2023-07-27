using Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison;

public sealed class Smallest : Scalar::Envelope<System::Single>
{
	public Smallest(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}

	public Smallest(IEnumerable<System::Single> singles) : base
	(
		new Scalar::Function.Result<System::Single>(singles.Min)
	)
	{
	}
}