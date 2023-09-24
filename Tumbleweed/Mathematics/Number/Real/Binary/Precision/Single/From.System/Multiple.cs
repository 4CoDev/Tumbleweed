using Tumbleweed.Enumerable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System;

public sealed class Multiple : Envelope<Any>
{
	public Multiple(IEnumerable<System::Single> singles) : base
	(
		new Selected<System::Single, Any>(
			singles,
			single => new One(single))
	)
	{
	}
}