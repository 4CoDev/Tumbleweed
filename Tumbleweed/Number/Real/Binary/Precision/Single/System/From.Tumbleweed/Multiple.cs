using Tumbleweed.Enumerable;
using System = System;
using Real = Tumbleweed.Number.Real;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single.System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;

public sealed class Multiple : Envelope<System::Single>
{
	public Multiple(IEnumerable<Real::Any> numbers) : base
	(
		new Selected<Real::Any, System::Single>(
			numbers,
			number => new Single::From.Tumbleweed.One(number).Value)
	)
	{
	}

}