using Tumbleweed.Collection.Scalar.Value;
using Tumbleweed.Storage.Record;
using Tumbleweed.Storage.Record.Value;

namespace Tumbleweed.Collection.Storage.Record.Value;

public sealed class NonNullable<T> : Envelope<T>
{
	public NonNullable
	(
		Any<ICollection<T>> element
	) : base
	(
		new Actual<T>(
			new Tumbleweed.Storage.Record.Value.NonNullable<ICollection<T>>(element))
	)
	{
	}
}