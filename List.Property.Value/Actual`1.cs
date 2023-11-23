using System.Collections;
using List = Tumbleweed.List;
using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.List.Property.Value;

public sealed class Actual<T> : List::Envelope<T>
{
	public Actual
	(
		Property::Any<IList<T>> property
	) : base
	(
		new List::Function.Result.Actual<T>(
			new Property::As.Function.Actual
				<IList<T>>
				(property))
	)
	{
	}
}