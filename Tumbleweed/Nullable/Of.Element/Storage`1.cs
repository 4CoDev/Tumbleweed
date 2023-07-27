using Tumbleweed.Storage.Record;
using Tumbleweed.Storage.Record.Value;

namespace Tumbleweed.Nullable.Of.Element;

public sealed class Storage<T> : Nullable.Envelope<T>
{
	public Storage
	(Storage.Record.Any<Nullable.Any<T>> element
	) : base
	(
		new Nullable.Of.Scalar<T>(
			new NonNullable<Nullable.Any<T>>(element))
	)
	{
	}
}