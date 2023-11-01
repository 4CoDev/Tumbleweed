using Property = Tumbleweed.Property.Output;
using SCG = System.Collections.Generic;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Property.Output.From.Enumerable;

public sealed class Single<T> : Property::Envelope<T>
{
	public Single
	(
		SCG::IEnumerable<T> enumerable
	) : base
	(
		new Property::From.Enumerable.At.Index.System<T>(
			new Enumerable::Requirement.Length.System<T>(
				enumerable,
				1),
			0)
	)
	{
	}
}