using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Collection.Item.At.Index.System;

public sealed class One<T> : Scalar::Envelope<T>
{
	public One(ICollection<T> collection, Int32 index) : this
	(
		collection,
		new Scalar::With.Value<Int32>(index)
	)
	{
	}
	
	public One
	(
		ICollection<T> collection,
		Scalar::Any<Int32> index
	) : base
	(
		new Scalar::Function.Result.Actual<T>(
			() => collection.ElementAt(index.Value))
	)
	{
	}
}