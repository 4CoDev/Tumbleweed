using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.String.Scalar.Value;

public sealed class Actual : Any
{
	public Actual(Any<Any> scalar) =>
		this.scalar = scalar;

	public override System::Boolean Equals(System::Object? @object) =>
		AsSystem.Equals(@object);

	public override Int32 GetHashCode() =>
		AsSystem.GetHashCode();

	public override global::System.String ToString() =>
		AsSystem;

	public global::System.String AsSystem =>
		scalar.Value.AsSystem;
	
	private readonly Any<Any> scalar;
}