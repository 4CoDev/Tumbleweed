using System.Collections;
using Tumbleweed.Scalar.Immutable;
using Scalar = Tumbleweed.Scalar;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Scalar;

public sealed class Value : IEnumerable
{
	public Value(Any<IEnumerable> scalar) =>
		this.scalar = scalar;

	public IEnumerator GetEnumerator() =>
		scalar.Value.GetEnumerator();

	public override System::Boolean Equals(System::Object? @object) =>
		scalar.Value.Equals(@object);

	public override Int32 GetHashCode() =>
		scalar.Value.GetHashCode();
	
	public override System::String? ToString() =>
		scalar.Value.ToString();

	private readonly Any<IEnumerable> scalar;
}