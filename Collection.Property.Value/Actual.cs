using System.Collections;
using Collection = Tumbleweed.Collection;
using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Collection.Property.Value;

public sealed class Actual<T> : Collection::Envelope<T>
{
	public Actual
	(
		Property::Any<ICollection<T>> property
	) : base
	(
		new Collection::Function.Result.Actual<T>(
			new Property::As.Function.Actual
				<ICollection<T>>
				(property))
	)
	{
	}
}