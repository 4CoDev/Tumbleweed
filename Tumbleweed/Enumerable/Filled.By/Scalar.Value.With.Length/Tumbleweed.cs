using Enumerable = Tumbleweed.Enumerable;
using Natural = Tumbleweed.Number.Natural;
using Scalar = Tumbleweed.Scalar.Immutable;
using Integer = Tumbleweed.Number.Integer;

namespace Tumbleweed.Enumerable.Filled.By.Scalar.Value.With.Length;

public sealed class Tumbleweed<T> : Enumerable::Envelope<T>
{
	public Tumbleweed
	(
		Natural::Any length,
		Scalar::Any<T> filler
	) : base
	(
		new Enumerable::Filled.By.Scalar.Value.With.Length.System<T>(
			new Integer::System.Medium.From.Natural.Tumbleweed.One(length),
			filler)
	)
	{
	}
}