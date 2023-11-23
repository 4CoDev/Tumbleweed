using Tumbleweed.Enumerable;
using Tumbleweed.Property.Output.From.Enumerable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Product : Tumbleweed.Property.Output.Envelope<System::Single>
{
	public Product(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}
	
	public Product(IEnumerable<System::Single> singles) : base
	(
		new Aggregated<System::Single>(
			singles,
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