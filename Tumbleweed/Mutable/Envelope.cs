using System = System;

namespace Tumbleweed.Mutable;

public abstract class Envelope<T> : Mutable.Any<T>
{
	protected Envelope(Mutable.Any<T> mutable) =>
		this.mutable = mutable;

	public override System::Boolean Equals(System::Object? @object) =>
		mutable.Equals(@object);

	public override Int32 GetHashCode() =>
		mutable.GetHashCode();

	public override System::String? ToString() =>
		mutable.ToString();

	public T Value
	{
		get => mutable.Value;
		set => mutable.Value = value;
	}

	private readonly Mutable.Any<T> mutable;
}