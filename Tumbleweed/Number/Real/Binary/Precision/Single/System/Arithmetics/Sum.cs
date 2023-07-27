using Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Sum : Scalar::Envelope<System::Single>
{
	public Sum(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}

	public Sum(IEnumerable<System::Single> singles) : base
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
		System::Single augend,
		System::Single addend
	) =>
	(
		augend + addend
	);
}