using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Collection.Item.At.Index.System;

public sealed class One<T> : Property::Envelope<T>
{
	public One(ICollection<T> collection, Int32 index) : this
	(
		collection,
		new Property::With.Value.One<Int32>(index)
	)
	{
	}
	
	public One
	(
		ICollection<T> collection,
		Property::Any<Int32> index
	) : base
	(
		new Property::Function.Result.Actual<T>(
			() => collection.ElementAt(index.Value))
	)
	{
	}
}