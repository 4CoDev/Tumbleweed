using Tumbleweed.Enumerable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;

public sealed class Multiple : Envelope<System::Single>
{
	public Multiple(IEnumerable<Any> numbers) : base
	(
		new Selected<Any, System::Single>(
			numbers,
			number => new One(number).Value)
	)
	{
	}

}