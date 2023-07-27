using Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Product : Scalar::Envelope<System::Single>
{
	public Product(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}
	
	public Product(IEnumerable<System::Single> singles) : base
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
		System::Single multiplicand,
		System::Single multiplier
	) =>
	(
		multiplicand * multiplier
	);
}