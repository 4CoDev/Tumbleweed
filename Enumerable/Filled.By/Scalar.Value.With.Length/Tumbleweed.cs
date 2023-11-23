using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Mathematics.Number.Natural;
using Enumerable = Tumbleweed.Enumerable;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property.Output;
using Integer = Tumbleweed.Mathematics.Number.Integer;

namespace Tumbleweed.Enumerable.Filled.By.Property.Value.With.Length;

public sealed class Tumbleweed<T> : Enumerable::Envelope<T>
{
	public Tumbleweed
	(
		Any length,
		Property::Any<T> filler
	) : base
	(
		new Enumerable::Filled.By.Property.Value.With.Length.System<T>(
			new One(length),
			filler)
	)
	{
	}
}