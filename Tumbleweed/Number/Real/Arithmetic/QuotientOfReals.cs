using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;
using One = Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One;


namespace Tumbleweed.Number.Real.Arithmetic;

public sealed class QuotientOfReals : Envelope
{
	public QuotientOfReals(params Any[] reals) : this
	(
		new Concatenated<Any>(reals)
	)
	{
	}
	
	public QuotientOfReals(IEnumerable<Any> reals) : base
	(
		new One(
			new Difference(
				new Multiple(reals)))
	)
	{
	}
}