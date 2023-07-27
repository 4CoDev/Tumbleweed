using Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Difference : Scalar::Envelope<System::Single>
{
	public Difference(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}
	
	public Difference(IEnumerable<System::Single> singles) : base
	(
		new Scalar::From.Enumerable.Aggregated<System::Single>(
			singles,
			0,
			Expression)
	)
	{
	}

	private static System::Single Expression
	(
		System::Single minuend,
		System::Single subtrahend
	) =>
	(
		minuend - subtrahend
	);
}