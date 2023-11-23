using Tumbleweed.Property.Output.Function.Result;
using Enumerable = Tumbleweed.Enumerable;
using Property = Tumbleweed.Property;

namespace Tumbleweed.Enumerable;

public sealed class Appended<T> : Enumerable::Envelope<T>
{
	public Appended
	(
		IEnumerable<T> enumerable,
		T value
	) : base
	(
		new Enumerable::Property.Value<T>(
			new Actual<IEnumerable<T>>(
				() => enumerable.Append(value)))
	)
	{
	}
}