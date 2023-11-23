using System = System;
using Property = Tumbleweed.Property;
using System.Collections;
using Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Property;

public sealed class Value<T> : IEnumerable<T>
{
	public Value(Any<IEnumerable<T>> property) =>
		this.property = property;

	IEnumerator IEnumerable.GetEnumerator() =>
			property.Value.GetEnumerator();
	
	public IEnumerator<T> GetEnumerator() =>
		property.Value.GetEnumerator();
	
	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		property.Value.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		property.Value.GetHashCode();
	
	public override System::String? ToString() =>
		property.Value.ToString();

	private readonly Any<IEnumerable<T>> property;
}