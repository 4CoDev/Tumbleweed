using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable.From.Enumerable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Quotient : Tumbleweed.Scalar.Immutable.Envelope<System::Single>
{
	public Quotient(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}

	public Quotient(IEnumerable<System::Single> singles) : base
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
		System::Single dividend,
		System::Single divisor
	) =>
	(
		dividend / divisor
	);
}