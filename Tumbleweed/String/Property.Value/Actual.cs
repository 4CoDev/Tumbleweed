using Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.String.Property.Value;

public sealed class Actual : Any
{
	public Actual(Any<Any> property) =>
		this.property = property;

	public override System::Boolean Equals(System::Object? @object) =>
		AsSystem.Equals(@object);

	public override Int32 GetHashCode() =>
		AsSystem.GetHashCode();

	public override global::System.String ToString() =>
		AsSystem;

	public global::System.String AsSystem =>
		property.Value.AsSystem;
	
	private readonly Any<Any> property;
}