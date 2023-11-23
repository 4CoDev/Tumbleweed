using System.Collections;
using Tumbleweed.Property.Output;
using Property = Tumbleweed.Property;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Property;

public sealed class Value : IEnumerable
{
	public Value(Any<IEnumerable> property) =>
		this.property = property;

	public IEnumerator GetEnumerator() =>
		property.Value.GetEnumerator();

	public override System::Boolean Equals(System::Object? @object) =>
		property.Value.Equals(@object);

	public override Int32 GetHashCode() =>
		property.Value.GetHashCode();
	
	public override System::String? ToString() =>
		property.Value.ToString();

	private readonly Any<IEnumerable> property;
}