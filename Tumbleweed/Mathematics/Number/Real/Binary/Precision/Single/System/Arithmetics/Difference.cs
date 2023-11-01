using Tumbleweed.Enumerable;
using Tumbleweed.Property.Output.From.Enumerable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Arithmetics;

public sealed class Difference : Tumbleweed.Property.Output.Envelope<System::Single>
{
	public Difference(params System::Single[] singles) : this
	(
		new Concatenated<System::Single>(singles)
	)
	{
	}
	
	public Difference(IEnumerable<System::Single> singles) : base
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
		System::Single minuend,
		System::Single subtrahend
	) =>
	(
		minuend - subtrahend
	);
}