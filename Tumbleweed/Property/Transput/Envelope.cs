using Property = Tumbleweed.Property.Transput;
using System = System;

namespace Tumbleweed.Property.Transput;

public abstract class Envelope<T> : Property::Any<T>
{
	protected Envelope(Property::Any<T> mutable) =>
		this.mutable = mutable;

	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		mutable.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		mutable.GetHashCode();

	public override System::String? ToString() =>
		mutable.ToString();

	public T Value
	{
		get => mutable.Value;
		set => mutable.Value = value;
	}

	private readonly Property::Any<T> mutable;
}