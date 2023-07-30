using System = System;
using Scalar = Tumbleweed.Scalar;
using System.Collections;
using Tumbleweed.Scalar.Immutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Scalar;

public sealed class Value<T> : IEnumerable<T>
{
	public Value(Any<IEnumerable<T>> scalar) =>
		this.scalar = scalar;

	IEnumerator IEnumerable.GetEnumerator() =>
			scalar.Value.GetEnumerator();
	
	public IEnumerator<T> GetEnumerator() =>
		scalar.Value.GetEnumerator();
	
	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		scalar.Value.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		scalar.Value.GetHashCode();
	
	public override System::String? ToString() =>
		scalar.Value.ToString();

	private readonly Any<IEnumerable<T>> scalar;
}