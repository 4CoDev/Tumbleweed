using Tumbleweed.Enumerable;
using Real = Tumbleweed.Number.Real;
using System = System;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.From.System;

public sealed class Multiple : Envelope<Real::Any>
{
	public Multiple(IEnumerable<System::Single> singles) : base
	(
		new Selected<System::Single, Real::Any>(
			singles,
			single => new Single::From.System.One(single))
	)
	{
	}
}