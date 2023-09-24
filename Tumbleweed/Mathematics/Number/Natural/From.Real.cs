using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.From.System;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From;
using Any = Tumbleweed.Mathematics.Number.Real.Any;
using Single = Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Float.With.Precision.Single;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Natural.From;

public sealed class Real : Number.Natural.Envelope
{
	public Real(Number.Real.Any real) : base
	(
		new One(
			new Single(
				new Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(real)))
	)
	{
	}
}