using Enumerable = Tumbleweed.Enumerable;
using Record = Tumbleweed.Storage.Record;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Storage.Record.Value;

public sealed class NonNullable<T> : Envelope<T>
{
	public NonNullable
	(
		Record::Any<SCG::IEnumerable<T>> record
	) : base
	(
		new Enumerable::Scalar.Value<T>(
			new Record::Value.NonNullable<SCG::IEnumerable<T>>(record))
	)
	{
	}
}