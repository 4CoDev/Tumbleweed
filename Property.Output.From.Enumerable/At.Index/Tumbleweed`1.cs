using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Property = Tumbleweed.Property.Output;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SystemInteger = Tumbleweed.Mathematics.Number.Integer.System.Medium;

namespace Tumbleweed.Property.Output.From.Enumerable.At.Index;

public sealed class Tumbleweed<T> : Property::Envelope<T>
{
	public Tumbleweed
	(
		SCG::IEnumerable<T> enumerable,
		Natural::Any index
	) : base
	(
		new Property::From.Enumerable.At.Index.System<T>(
			enumerable,
			new One(index))
	)
	{
	}
}