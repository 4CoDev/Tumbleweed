using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;
using Single = Tumbleweed.Number.Integer.System.Medium.From.Float.With.Precision.Single;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Natural.From;

public sealed class Real : Natural.Envelope
{
	public Real(Number.Real.Any real) : base
	(
		new Natural.From.System.One(
			new Single(
				new One(real)))
	)
	{
	}
}