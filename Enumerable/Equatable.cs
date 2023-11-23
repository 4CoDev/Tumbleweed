using Tumbleweed.Enumerable.Equality.Structural.Of.Option;
using SC = System.Collections;
using System = System;
using Equality = Tumbleweed.Enumerable.Equality;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Enumerable;

public sealed class Equatable : SC::IEnumerable
{
	public Equatable(SC::IEnumerable enumerable) =>
		this.enumerable = enumerable;

	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		new Two(this, @object).State
	);

	public override System::Int32 GetHashCode() =>
		new Object::Hash.HashFromObjects(enumerable).Value;

	public override System::String ToString() =>
		new Object::String.StringFromObjects(enumerable).AsSystem;

	public SC::IEnumerator GetEnumerator() =>
		enumerable.GetEnumerator();

	private readonly SC::IEnumerable enumerable;
}