using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Mathematics.Number.Natural;
using Enumerable = Tumbleweed.Enumerable;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using Scalar = Tumbleweed.Scalar.Immutable;
using Integer = Tumbleweed.Mathematics.Number.Integer;

namespace Tumbleweed.Enumerable.Filled.By.Scalar.Value.With.Length;

public sealed class Tumbleweed<T> : Enumerable::Envelope<T>
{
	public Tumbleweed
	(
		Any length,
		Scalar::Any<T> filler
	) : base
	(
		new Enumerable::Filled.By.Scalar.Value.With.Length.System<T>(
			new One(length),
			filler)
	)
	{
	}
}