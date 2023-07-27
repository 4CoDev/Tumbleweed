using Tumbleweed.Boolean;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Nullable.Of;

public sealed class Scalar<T> : Nullable.Any<T>
{
	public Scalar(Scalar.Any<Nullable.Any<T>> scalar) =>
		this.scalar = scalar;

	public override System::Boolean Equals(System::Object? @object) =>
		scalar.Value.Equals(@object);

	public override Int32 GetHashCode() =>
		scalar.Value.GetHashCode();

	public override System::String? ToString() =>
		scalar.Value.ToString();

	public T Value =>
		scalar.Value.Value;

	public Any HasValue =>
		scalar.Value.HasValue;

	private readonly Scalar.Any<Nullable.Any<T>> scalar;
}