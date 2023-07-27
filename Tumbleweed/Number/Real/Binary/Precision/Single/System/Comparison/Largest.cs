using Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison;

public sealed class Largest : Scalar::Envelope<System::Single>
{
	public Largest(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}

	public Largest(IEnumerable<System::Single> singles) : base
	(
		new Scalar::Function.Result<System::Single>(singles.Max)
	)
	{
	}
}