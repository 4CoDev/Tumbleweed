using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable.From.Enumerable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Sum : Tumbleweed.Scalar.Immutable.Envelope<System::Single>
{
	public Sum(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}

	public Sum(IEnumerable<System::Single> singles) : base
	(
		new Aggregated<System::Single>(
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